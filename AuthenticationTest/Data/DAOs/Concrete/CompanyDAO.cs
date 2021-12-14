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

        public void CreateCompany(Company company)
        {
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                conn.Open();
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

        public Company getCompanyForUserById(string id)
        {
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
                conn.Open();
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
    }
}