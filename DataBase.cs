using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MyFitnessPal
{
    static class DataBase
    {
        public static String ConnectionString = "";
        public static void init()
        {
            ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + "\\Namirnice.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        }
        public static DataTable executeQuery(String sQuery)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(sQuery, conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        try
                        {
                            dataAdapter.Fill(dt);

                            conn.Close();
                            conn.Dispose();
                        }
                        catch (Exception ex)
                        {

                            conn.Close();
                            conn.Dispose();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            return dt;
        }



        public static void executeNonQuery(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                try
                {
                    command.ExecuteNonQuery();

                    connection.Close();
                    connection.Dispose();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    connection.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
