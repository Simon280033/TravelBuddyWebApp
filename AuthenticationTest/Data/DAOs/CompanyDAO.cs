using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace AuthenticationTest.Data
{
    public class CompanyDAO : ICompanyDAO
    {
        private NpgsqlConnection conn;
        
        public CompanyDAO(NpgsqlConnection conn)
        {
            this.conn = conn;
        }

        public bool userTiedToCompany(string userName)
        {
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT COUNT(*) AS AMOUNT FROM travelbuddy.aspnet_user_company_relations WHERE AspNetUser_name = @userName;";
                command.Parameters.AddWithValue("userName", userName);
                command.Connection = conn;
                conn.Open();
                
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        int amount = int.Parse(sdr["amount"].ToString());
                        if (amount > 0)
                        {
                            return true;
                        }
                    }
                }
                conn.Close();
            }

            return false;
        }

        public List<string> getCustomers()
        {
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM travelbuddy.Companies;";
                command.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["company_name"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
        
        public void getCompanyById(int id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM travelbuddy.Companies WHERE company_id = @companyId;";
                command.Parameters.AddWithValue("companyId", id);
                command.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["company_name"].ToString());
                    }
                }
                conn.Close();
            }
        }
    }
}