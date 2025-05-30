using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace YurtÖğrenciOtomasyonSistem
{
    public static class Database
    {
        private static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=YurtÖğrenciOtomasyonSistem;Integrated Security=True";

        public static DataTable GetData(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorgu hatası: " + ex.Message);
                    return null;
                }
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Komut hatası: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}