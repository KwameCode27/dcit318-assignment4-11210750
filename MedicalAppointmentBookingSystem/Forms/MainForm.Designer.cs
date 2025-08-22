using System.Windows.Forms;

namespace MedicalAppointmentBookingSystem.Forms
{
    public partial class MainForm : Form
    {
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtSearch;
        private Button btnAddMedicine;
        private Button btnSearch;
        private Button btnUpdateStock;
        private Button btnRecordSale;
        private Button btnViewAll;
        private DataGridView dgvMedicines;

        private void InitializeComponent()
        {
            this.txtName = new TextBox { PlaceholderText = "Medicine Name" };
            this.txtCategory = new TextBox { PlaceholderText = "Category" };
            this.txtPrice = new TextBox { PlaceholderText = "Price" };
            this.txtQuantity = new TextBox { PlaceholderText = "Quantity" };
            this.txtSearch = new TextBox { PlaceholderText = "Search" };
            this.btnAddMedicine = new Button { Text = "Add Medicine" };
            this.btnSearch = new Button { Text = "Search" };
            this.btnUpdateStock = new Button { Text = "Update Stock" };
            this.btnRecordSale = new Button { Text = "Record Sale" };
            this.btnViewAll = new Button { Text = "View All" };
            this.dgvMedicines = new DataGridView { Width = 600, Height = 200 };

            // Layout code (simplified)
            this.Controls.Add(txtName);
            this.Controls.Add(txtCategory);
            this.Controls.Add(txtPrice);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnAddMedicine);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnUpdateStock);
            this.Controls.Add(btnRecordSale);
            this.Controls.Add(btnViewAll);
            this.Controls.Add(dgvMedicines);

            // Set positions and sizes (for demonstration)
            txtName.Top = 10; txtName.Left = 10; txtName.Width = 150;
            txtCategory.Top = 40; txtCategory.Left = 10; txtCategory.Width = 150;
            txtPrice.Top = 70; txtPrice.Left = 10; txtPrice.Width = 150;
            txtQuantity.Top = 100; txtQuantity.Left = 10; txtQuantity.Width = 150;
            txtSearch.Top = 130; txtSearch.Left = 10; txtSearch.Width = 150;
            btnAddMedicine.Top = 10; btnAddMedicine.Left = 180;
            btnSearch.Top = 40; btnSearch.Left = 180;
            btnUpdateStock.Top = 70; btnUpdateStock.Left = 180;
            btnRecordSale.Top = 100; btnRecordSale.Left = 180;
            btnViewAll.Top = 130; btnViewAll.Left = 180;
            dgvMedicines.Top = 170; dgvMedicines.Left = 10;
        }
    }
}
