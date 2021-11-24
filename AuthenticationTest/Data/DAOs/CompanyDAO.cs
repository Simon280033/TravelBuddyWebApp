using System;
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
        
        public void getCompanyById(int id)
        {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        
            conn.Open();
            // quite complex sql statement
            string sql = "SELECT * FROM travelbuddy.companies WHERE company_id = " +  id + ";";
            // data adapter making request from our connection
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            //dataGridView1.DataSource = dt;
            DataRow dr = dt.Rows[0];
        
            Console.Write(dr["company_name"]);
            // since we only showing the result we don't need connection anymore
            conn.Close();
        }
    }
}