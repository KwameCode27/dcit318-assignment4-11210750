using System.Windows.Forms;

namespace MedicalAppointmentBookingSystem.Forms
{
    public partial class AppointmentForm : Form
    {
        private ComboBox cmbDoctors;
        private ComboBox cmbPatients;
        private DateTimePicker dtpAppointmentDate;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnBookAppointment;
        private Button btnSearchAppointments;
        private Button btnDeleteAppointment;
        private Button btnModifyAppointment;
        private DataGridView dgvAppointments;
        private TextBox txtSearchAppointments;

        private void InitializeComponent()
        {
            this.cmbDoctors = new ComboBox { Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            this.cmbPatients = new ComboBox { Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            this.dtpAppointmentDate = new DateTimePicker { Width = 200 };
            this.txtCategory = new TextBox { PlaceholderText = "Category" };
            this.txtPrice = new TextBox { PlaceholderText = "Price" };
            this.txtQuantity = new TextBox { PlaceholderText = "Quantity" };
            this.btnBookAppointment = new Button { Text = "Book Appointment" };
            this.btnSearchAppointments = new Button { Text = "Search Appointments" };
            this.btnDeleteAppointment = new Button { Text = "Delete Appointment" };
            this.btnModifyAppointment = new Button { Text = "Modify Appointment" };
            this.dgvAppointments = new DataGridView { Width = 600, Height = 200 };
            this.txtSearchAppointments = new TextBox { PlaceholderText = "Search Appointments" };

            // Layout code (simplified)
            this.Controls.Add(cmbDoctors);
            this.Controls.Add(cmbPatients);
            this.Controls.Add(dtpAppointmentDate);
            this.Controls.Add(txtCategory);
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(btnBookAppointment);
            this.Controls.Add(btnSearchAppointments);
            this.Controls.Add(btnDeleteAppointment);
            this.Controls.Add(btnModifyAppointment);
            this.Controls.Add(dgvAppointments);
            this.Controls.Add(txtSearchAppointments);

            // Set positions and sizes (for demonstration)
            cmbDoctors.Top = 10; cmbDoctors.Left = 10;
            cmbPatients.Top = 40; cmbPatients.Left = 10;
            dtpAppointmentDate.Top = 70; dtpAppointmentDate.Left = 10;
            txtCategory.Top = 100; txtCategory.Left = 10;
            txtPrice.Top = 130; txtPrice.Left = 10;
            txtQuantity.Top = 160; txtQuantity.Left = 10;
            btnBookAppointment.Top = 10; btnBookAppointment.Left = 220;
            btnSearchAppointments.Top = 40; btnSearchAppointments.Left = 220;
            btnDeleteAppointment.Top = 70; btnDeleteAppointment.Left = 220;
            btnModifyAppointment.Top = 100; btnModifyAppointment.Left = 220;
            txtSearchAppointments.Top = 130; txtSearchAppointments.Left = 220;
            dgvAppointments.Top = 200; dgvAppointments.Left = 10;
        }
    }
}
