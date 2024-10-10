using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project999.Database
{
    class DatabaseClass
    {
        SqlConnection con = new SqlConnection();
        /*
         * Mohammed:
         * In the connectionString Server = (--------------------) <-- here place your server name
         * 
         * NAJM:
         * I dont Know How.
         * 
         * Mohammed:
         * *&^%$#@
         * 
         */
        string connectionString = @"Server=DESKTOP-C1HQPKO; Database=SchoolDB; Integrated Security = true";

        public DatabaseClass()
        {
            con = new SqlConnection(connectionString);
        }

        // Opem sql Connection method
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // Close sql Connection method
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        // Read Data from the Database
        public DataTable read(string store, SqlParameter[] pr)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            
            com.CommandText = store;

            if (pr != null)
            {
                com.Parameters.AddRange(pr);
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        // INSERT, UPDATE, DELETE method
        public void exce(string store, SqlParameter[] pr)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = store;

            if (pr != null)
            {
                com.Parameters.AddRange(pr);
            }
            com.ExecuteNonQuery();
        }

    }
}
