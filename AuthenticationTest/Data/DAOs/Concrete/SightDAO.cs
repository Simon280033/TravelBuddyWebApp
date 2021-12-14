using System;
using System.Data;
using AuthenticationTest.Data.Entities;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class SightDAO : ISightDAO
    {
        private NpgsqlConnection conn;
        
        public SightDAO(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
        
        private void OpenConnIfClosed()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        
        public int CreateNewSightAndVariant(Sight sight, int tourId, string languageCode)
        {
            int newId = CreateSight(sight, tourId);
            sight.Id = newId;
            CreateVariant(sight, tourId, languageCode);
            return newId;
        }

        private int CreateSight(Sight sight, int tourId)
        {
            Console.WriteLine("CreateSight");
            int newId = 0;
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText =
                    "INSERT INTO travelbuddy.Sights VALUES(DEFAULT, @tourId, @lat, @lng, @radius, @imageBase64) RETURNING sight_id;";
                command.Connection = conn;
                command.Parameters.AddWithValue("tourId", tourId);
                command.Parameters.AddWithValue("lat", sight.Latitude);
                command.Parameters.AddWithValue("lng", sight.Longitude);
                command.Parameters.AddWithValue("radius", sight.RadiusInMeters);
                command.Parameters.AddWithValue("imageBase64", sight.ImageBase64);
                command.Prepare();
                command.ExecuteNonQuery();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        newId = (int) Int32.Parse(sdr["sight_id"].ToString());
                    }
                }
            }
            conn.Close();
            Console.WriteLine("ID for newly created sight: " + newId);
            return newId;
        }
        
        public void CreateVariant(Sight sight, int tourId, string languageCode)
        {
            Console.WriteLine("CreateVariant");
            // We get the variant
            SightVariant variant = new SightVariant();
            foreach (SightVariant sv in sight.Variants)
            {
                if (sv.Language.LanguageCode.Equals(languageCode))
                {
                    variant.SightName = sv.SightName;
                    variant.SightDescription = sv.SightDescription;
                    variant.AudioBase64 = sv.AudioBase64;
                    variant.AudioFileName = sv.AudioFileName;
                    break;
                }
            }
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText =
                    "INSERT INTO travelbuddy.Sight_variants VALUES(@sightId, " +
                    "@languageCode, @sightName, @sightDesc, @audioBase64, @audioFileName)";
                command.Connection = conn;
                command.Parameters.AddWithValue("sightId", sight.Id);
                command.Parameters.AddWithValue("languageCode", languageCode);
                command.Parameters.AddWithValue("sightName", variant.SightName);
                command.Parameters.AddWithValue("sightDesc", variant.SightDescription);
                command.Parameters.AddWithValue("audioBase64", variant.AudioBase64);
                command.Parameters.AddWithValue("audioFileName", variant.AudioFileName);
                command.Prepare();
                command.ExecuteNonQuery();
            }
            conn.Close();    
        }
    }
}