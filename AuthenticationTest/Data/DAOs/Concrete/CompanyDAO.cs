using System;
using System.Collections.Generic;
using System.Data;
using AuthenticationTest.Data.Entities;
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
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT COUNT(*) AS AMOUNT FROM travelbuddy.aspnet_user_company_relations WHERE AspNetUser_name = (SELECT \"Id\" FROM public.\"AspNetUsers\" WHERE \"Email\" = @email);";
                command.Parameters.AddWithValue("email", userName);
                command.Connection = conn;
                
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
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM travelbuddy.Companies;";
                command.Connection = conn;
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

        public void CreateCompany(Company company)
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText =
                    "INSERT INTO travelbuddy.Companies VALUES(DEFAULT, @companyName, @address, @email, @phone);";
                command.Connection = conn;
                command.Parameters.AddWithValue("companyName", company.name);
                command.Parameters.AddWithValue("address", company.address);
                command.Parameters.AddWithValue("email", company.email);
                command.Parameters.AddWithValue("phone", company.phone);
                command.Prepare();
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void TieCompanyToUser(Company company)
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText =
                    "INSERT INTO travelbuddy.aspnet_user_company_relations VALUES((SELECT \"Id\" FROM public.\"AspNetUsers\" WHERE \"Email\" = @email), (SELECT company_id FROM travelbuddy.Companies WHERE email = @email));";
                command.Connection = conn;
                command.Parameters.AddWithValue("email", company.email);
                command.Prepare();
                command.ExecuteNonQuery();
            }
            conn.Close();        
        }

        public void UpdateCompany(Company company)
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText =
                    "UPDATE travelbuddy.Companies SET company_name = @name, address = @address, phone = @phone WHERE email = @email;";
                command.Connection = conn;
                command.Parameters.AddWithValue("name", company.name);
                command.Parameters.AddWithValue("address", company.address);
                command.Parameters.AddWithValue("phone", company.phone);
                command.Parameters.AddWithValue("email", company.email);
                command.Prepare();
                command.ExecuteNonQuery();
            }
            conn.Close();         
        }

        public Company getCompanyForUserById(string id)
        {
            OpenConnIfClosed();
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                command.CommandText = "SELECT * FROM " + 
                                      "travelbuddy.companies " +
                                      "LEFT JOIN " +
                                      "travelbuddy.aspnet_user_company_relations " +
                                      "ON " +
                                      "travelbuddy.aspnet_user_company_relations.company_id = travelbuddy.companies.company_id " +
                                      "WHERE " +
                                      "travelbuddy.aspnet_user_company_relations.AspNetUser_name = (SELECT \"Id\" FROM public.\"AspNetUsers\" WHERE \"Email\" = @email);";
                command.Parameters.AddWithValue("email", id);
                command.Connection = conn;
                using (NpgsqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Company company = new Company
                        {
                            id = (int) Int32.Parse(sdr["company_id"].ToString()),
                            address = sdr["address"].ToString(),
                            email = sdr["email"].ToString(),
                            name = sdr["company_name"].ToString(),
                            phone = sdr["phone"].ToString()
                        };
                        return company;
                    }
                }
                conn.Close();
            }
            return null;
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