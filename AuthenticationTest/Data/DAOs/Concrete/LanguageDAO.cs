using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using AuthenticationTest.Data.Entities;
using Npgsql;
using Json.Net;

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
        
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("langs.json"))
            {
                string json = r.ReadToEnd();
                List<JSONClass> items = JsonNet.Deserialize<List<JSONClass>>(json);
                
                foreach (var item in items)
                {
                    Console.WriteLine("Code: " + item.code + ", name: " + item.name);
                    SeedLanguage(item);
                }
            }
        }
        public class JSONClass
        {
            public string name { get; set; }      
            public string code { get; set; }
        }
        
        private void SeedLanguage(JSONClass item)
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText =
                    "INSERT INTO travelbuddy.Languages VALUES(@code, @name) ON CONFLICT DO NOTHING;";
                command.Connection = conn;
                command.Parameters.AddWithValue("code", item.code.ToUpper());
                command.Parameters.AddWithValue("name", item.name);
                command.Prepare();
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}