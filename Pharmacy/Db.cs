using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Pharmacy
{
    internal class Db
    {
            public static string connectionString = ConfigurationManager.ConnectionStrings["PharmacyDBConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            public SqlCommand sqlCommand;

            public Db()
            {
                //sqlCommand = new SqlCommand("SELECT * FROM Doctors", sqlConnection);
                ////sqlConnection.Open();
                //SqlDataReader reader = sqlCommand.ExecuteReader();
                //Console.WriteLine(reader.ToString());
    }
        public void AddMedicine(string name, string category, decimal price, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("AddMedicine", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchMedicine(string searchTerm)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SearchMedicine", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public void UpdateStock(int medicineID, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateStock", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MedicineID", medicineID);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RecordSale(int medicineID, int quantitySold)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("RecordSale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MedicineID", medicineID);
                    cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Handle errors, e.g. stock not enough
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public DataTable GetAllMedicines()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetAllMedicines", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

    }
}
