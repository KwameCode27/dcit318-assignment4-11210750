using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = MedicineName.Text;
                string category = MedicineCategory.Text;
                decimal price = Price.Value;
                int quantity = (int)Amount.Value;
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) || price <= 0 || quantity <= 0)
                {
                    MessageBox.Show("Please fill in all fields with valid values.");
                    return;
                }
                Db db = new Db();
                db.AddMedicine(name, category, price, quantity);
                MessageBox.Show("Medicine added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();


            }
        }
    }
}
