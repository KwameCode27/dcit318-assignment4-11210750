namespace Pharmacy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ViewAll = new Button();
            RecordSale = new Button();
            UpdateStock = new Button();
            Search = new Button();
            AddMedicine = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ViewAll);
            panel1.Controls.Add(RecordSale);
            panel1.Controls.Add(UpdateStock);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(AddMedicine);
            panel1.Location = new Point(81, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 255);
            panel1.TabIndex = 0;
            // 
            // ViewAll
            // 
            ViewAll.Location = new Point(201, 173);
            ViewAll.Name = "ViewAll";
            ViewAll.Size = new Size(163, 23);
            ViewAll.TabIndex = 4;
            ViewAll.Text = "View All";
            ViewAll.UseVisualStyleBackColor = true;
            ViewAll.Click += ViewAll_Click;
            // 
            // RecordSale
            // 
            RecordSale.Location = new Point(201, 98);
            RecordSale.Name = "RecordSale";
            RecordSale.Size = new Size(163, 23);
            RecordSale.TabIndex = 3;
            RecordSale.Text = "Record Sale";
            RecordSale.UseVisualStyleBackColor = true;
            RecordSale.Click += RecordSale_Click;
            // 
            // UpdateStock
            // 
            UpdateStock.Location = new Point(14, 173);
            UpdateStock.Name = "UpdateStock";
            UpdateStock.Size = new Size(163, 23);
            UpdateStock.TabIndex = 2;
            UpdateStock.Text = "Update Stock";
            UpdateStock.UseVisualStyleBackColor = true;
            UpdateStock.Click += UpdateStock_Click;
            // 
            // Search
            // 
            Search.Location = new Point(14, 98);
            Search.Name = "Search";
            Search.Size = new Size(163, 23);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // AddMedicine
            // 
            AddMedicine.Location = new Point(107, 50);
            AddMedicine.Name = "AddMedicine";
            AddMedicine.Size = new Size(163, 23);
            AddMedicine.TabIndex = 0;
            AddMedicine.Text = "Add Medicine";
            AddMedicine.UseVisualStyleBackColor = true;
            AddMedicine.Click += AddMedicine_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(568, 381);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddMedicine;
        private Button Search;
        private Button UpdateStock;
        private Button RecordSale;
        private Button ViewAll;
    }
}
