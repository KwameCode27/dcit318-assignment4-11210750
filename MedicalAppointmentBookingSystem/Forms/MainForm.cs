using System;
using System.Windows.Forms;
using MedicalAppointmentBookingSystem.Logic;

namespace MedicalAppointmentBookingSystem.Forms
{
    public partial class MainForm : Form
    {
        private MedicineLogic medicineLogic;

        public MainForm()
        {
            InitializeComponent();
            medicineLogic = new MedicineLogic();
            btnAddMedicine.Click += btnAddMedicine_Click;
            btnSearch.Click += btnSearch_Click;
            btnUpdateStock.Click += btnUpdateStock_Click;
            btnRecordSale.Click += btnRecordSale_Click;
            btnViewAll.Click += btnViewAll_Click;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                medicineLogic.AddMedicine(txtName.Text, txtCategory.Text, txtPrice.Text, txtQuantity.Text);
                MessageBox.Show("Medicine added successfully!");
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMedicines.DataSource = medicineLogic.SearchMedicine(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                medicineLogic.UpdateStock(txtName.Text, txtQuantity.Text);
                MessageBox.Show("Stock updated successfully!");
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            try
            {
                medicineLogic.RecordSale(txtName.Text, txtQuantity.Text);
                MessageBox.Show("Sale recorded successfully!");
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadMedicines()
        {
            dgvMedicines.DataSource = medicineLogic.GetAllMedicines();
        }
    }
}
