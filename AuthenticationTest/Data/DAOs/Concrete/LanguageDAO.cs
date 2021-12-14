using System.Collections.Generic;
using System.Data;
using AuthenticationTest.Data.Entities;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class LanguageDAO : ILanguageDAO
    {
        private NpgsqlConnection conn;
        
        public LanguageDAO(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
        
        public List<Language> GetLanguages()
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM travelbuddy.Languages;";
                command.Connection = conn;
                List<Language> languages = new List<Language>();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Language toAdd = new Language
                        {
                            LanguageCode = sdr["language_code"].ToString(),
                            LanguageName = sdr["language_name"].ToString()
                        };
                        languages.Add(toAdd);
                    }
                }
                conn.Close();
                return languages;
            }
        }
        
        private void OpenConnIfClosed()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}