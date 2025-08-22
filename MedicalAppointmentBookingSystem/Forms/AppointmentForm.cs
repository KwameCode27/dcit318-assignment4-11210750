using System;
using System.Windows.Forms;
using MedicalAppointmentBookingSystem.Logic;

namespace MedicalAppointmentBookingSystem.Forms
{
    public partial class AppointmentForm : Form
    {
        private AppointmentLogic appointmentLogic;

        public AppointmentForm()
        {
            InitializeComponent();
            appointmentLogic = new AppointmentLogic();
            btnBookAppointment.Click += btnBookAppointment_Click;
            btnSearchAppointments.Click += btnSearchAppointments_Click;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            btnModifyAppointment.Click += btnModifyAppointment_Click;
            LoadDoctors();
            LoadPatients();
            LoadAppointments();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                appointmentLogic.BookAppointment(
                    cmbPatients.SelectedValue.ToString(),
                    cmbDoctors.SelectedValue.ToString(),
                    dtpAppointmentDate.Value,
                    txtCategory.Text,
                    txtPrice.Text,
                    txtQuantity.Text
                );
                MessageBox.Show("Appointment booked successfully!");
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearchAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAppointments.DataSource = appointmentLogic.SearchAppointments(txtSearchAppointments.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAppointments.SelectedRows.Count > 0)
                {
                    var appointmentId = dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value.ToString();
                    appointmentLogic.DeleteAppointment(appointmentId);
                    MessageBox.Show("Appointment deleted successfully!");
                    LoadAppointments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModifyAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAppointments.SelectedRows.Count > 0)
                {
                    var appointmentId = dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value.ToString();
                    appointmentLogic.ModifyAppointment(
                        appointmentId,
                        cmbPatients.SelectedValue.ToString(),
                        cmbDoctors.SelectedValue.ToString(),
                        dtpAppointmentDate.Value,
                        txtCategory.Text,
                        txtPrice.Text,
                        txtQuantity.Text
                    );
                    MessageBox.Show("Appointment modified successfully!");
                    LoadAppointments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDoctors()
        {
            cmbDoctors.DataSource = appointmentLogic.GetDoctors();
            cmbDoctors.DisplayMember = "FullName";
            cmbDoctors.ValueMember = "DoctorID";
        }

        private void LoadPatients()
        {
            cmbPatients.DataSource = appointmentLogic.GetPatients();
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "PatientID";
        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = appointmentLogic.GetAllAppointments();
        }
    }
}
