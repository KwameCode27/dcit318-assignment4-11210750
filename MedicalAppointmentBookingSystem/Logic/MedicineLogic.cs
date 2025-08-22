using System;
using System.Data;
using Npgsql;

namespace MedicalAppointmentBookingSystem.Logic
{
    public class MedicineLogic
    {
        private string connectionString = "Host=localhost;Port=5432;Database=MedicalDB;Username=fentengMichael;Password=yourpassword;"; // Update as needed

        public void AddMedicine(string name, string category, string price, string quantity)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("INSERT INTO Medicines (Name, Category, Price, Quantity) VALUES (@Name, @Category, @Price, @Quantity)", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(price));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SearchMedicine(string searchTerm)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("SELECT * FROM Medicines WHERE Name ILIKE @SearchTerm OR Category ILIKE @SearchTerm", conn);
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                conn.Open();
                var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        public void UpdateStock(string name, string quantity)
        {
            int medicineId = GetMedicineIdByName(name);
            if (medicineId == -1) throw new Exception("Medicine not found.");
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("UPDATE Medicines SET Quantity = @Quantity WHERE MedicineID = @MedicineID", conn);
                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RecordSale(string name, string quantitySold)
        {
            int medicineId = GetMedicineIdByName(name);
            if (medicineId == -1) throw new Exception("Medicine not found.");
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("INSERT INTO Sales (MedicineID, QuantitySold, SaleDate) VALUES (@MedicineID, @QuantitySold, NOW()); UPDATE Medicines SET Quantity = Quantity - @QuantitySold WHERE MedicineID = @MedicineID;", conn);
                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                cmd.Parameters.AddWithValue("@QuantitySold", int.Parse(quantitySold));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllMedicines()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("SELECT * FROM Medicines", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        private int GetMedicineIdByName(string name)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var cmd = new NpgsqlCommand("SELECT MedicineID FROM Medicines WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}
