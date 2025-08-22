using System;
using System.Data;
using System.Data.SqlClient;

namespace MedicalAppointmentBookingSystem.Logic
{
    public class AppointmentLogic
    {
        private string connectionString = "Server=YOUR_SERVER;Database=MedicalDB;Trusted_Connection=True;"; // Update as needed

        public void BookAppointment(string patientId, string doctorId, DateTime appointmentDate, string category, string price, string quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Category, Price, Quantity) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Category, @Price, @Quantity)", conn);
                cmd.Parameters.AddWithValue("@PatientID", int.Parse(patientId));
                cmd.Parameters.AddWithValue("@DoctorID", int.Parse(doctorId));
                cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(price));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SearchAppointments(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments WHERE Category LIKE @Search OR Price LIKE @Search", conn);
                cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        public void DeleteAppointment(string appointmentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID = @AppointmentID", conn);
                cmd.Parameters.AddWithValue("@AppointmentID", int.Parse(appointmentId));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyAppointment(string appointmentId, string patientId, string doctorId, DateTime appointmentDate, string category, string price, string quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Appointments SET PatientID=@PatientID, DoctorID=@DoctorID, AppointmentDate=@AppointmentDate, Category=@Category, Price=@Price, Quantity=@Quantity WHERE AppointmentID=@AppointmentID", conn);
                cmd.Parameters.AddWithValue("@AppointmentID", int.Parse(appointmentId));
                cmd.Parameters.AddWithValue("@PatientID", int.Parse(patientId));
                cmd.Parameters.AddWithValue("@DoctorID", int.Parse(doctorId));
                cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(price));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        public DataTable GetDoctors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT DoctorID, FullName FROM Doctors WHERE Availability = 1", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        public DataTable GetPatients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT PatientID, FullName FROM Patients", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
    }
}
