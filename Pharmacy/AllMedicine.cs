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
    public partial class AllMedicine : Form
    {
        public AllMedicine()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AllMedicine_Load);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllMedicine_Load(object? sender, EventArgs e)
        {
            try
            {
                Db db = new Db();
                DataTable dt = db.GetAllMedicines();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MedicineID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message);
            }
        }

        private void AllMedicine_Load_1(object sender, EventArgs e)
        {

        }
    }
}
