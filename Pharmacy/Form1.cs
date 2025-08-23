namespace Pharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RecordSale_Click(object sender, EventArgs e)
        {
            RecordSale recordSaleForm = new RecordSale();
            recordSaleForm.ShowDialog();
        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicineForm = new AddMedicine();
            addMedicineForm.ShowDialog();
        }

        private void UpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock updateStockForm = new UpdateStock();
            updateStockForm.ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.ShowDialog();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            AllMedicine allMedicineForm = new AllMedicine();
            allMedicineForm.ShowDialog();
        }
    }
}
