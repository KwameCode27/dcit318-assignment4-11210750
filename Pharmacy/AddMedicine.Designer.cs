namespace Pharmacy
{
    partial class AddMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MedicineName = new TextBox();
            MedicineCategory = new TextBox();
            Price = new NumericUpDown();
            Amount = new NumericUpDown();
            panel1 = new Panel();
            label1 = new Label();
            mPrice = new Label();
            name = new Label();
            quantity = new Label();
            category = new Label();
            save = new Button();
            ((System.ComponentModel.ISupportInitialize)Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Amount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MedicineName
            // 
            MedicineName.Location = new Point(34, 65);
            MedicineName.Name = "MedicineName";
            MedicineName.Size = new Size(136, 23);
            MedicineName.TabIndex = 0;
            // 
            // MedicineCategory
            // 
            MedicineCategory.Location = new Point(237, 65);
            MedicineCategory.Name = "MedicineCategory";
            MedicineCategory.Size = new Size(136, 23);
            MedicineCategory.TabIndex = 1;
            // 
            // Price
            // 
            Price.DecimalPlaces = 2;
            Price.Location = new Point(34, 135);
            Price.Name = "Price";
            Price.Size = new Size(136, 23);
            Price.TabIndex = 3;
            // 
            // Amount
            // 
            Amount.Location = new Point(237, 135);
            Amount.Name = "Amount";
            Amount.Size = new Size(136, 23);
            Amount.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(save);
            panel1.Controls.Add(category);
            panel1.Controls.Add(quantity);
            panel1.Controls.Add(name);
            panel1.Controls.Add(mPrice);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Amount);
            panel1.Controls.Add(Price);
            panel1.Controls.Add(MedicineCategory);
            panel1.Controls.Add(MedicineName);
            panel1.Location = new Point(75, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 213);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(141, 13);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 5;
            label1.Text = "Add New Medicine";
            label1.Click += label1_Click;
            // 
            // mPrice
            // 
            mPrice.AutoSize = true;
            mPrice.BorderStyle = BorderStyle.FixedSingle;
            mPrice.Location = new Point(80, 117);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(35, 17);
            mPrice.TabIndex = 7;
            mPrice.Text = "Price";
            mPrice.Click += label3_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Location = new Point(80, 45);
            name.Name = "name";
            name.Size = new Size(41, 17);
            name.TabIndex = 8;
            name.Text = "Name";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BorderStyle = BorderStyle.FixedSingle;
            quantity.Location = new Point(280, 117);
            quantity.Name = "quantity";
            quantity.Size = new Size(55, 17);
            quantity.TabIndex = 9;
            quantity.Text = "Quantity";
            // 
            // category
            // 
            category.AutoSize = true;
            category.BorderStyle = BorderStyle.FixedSingle;
            category.Location = new Point(278, 47);
            category.Name = "category";
            category.Size = new Size(57, 17);
            category.TabIndex = 10;
            category.Text = "Category";
            category.Click += label6_Click;
            // 
            // save
            // 
            save.Location = new Point(141, 175);
            save.Name = "save";
            save.Size = new Size(110, 23);
            save.TabIndex = 11;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(551, 316);
            Controls.Add(panel1);
            Name = "AddMedicine";
            Text = "AddMedicine";
            ((System.ComponentModel.ISupportInitialize)Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)Amount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox MedicineName;
        private TextBox MedicineCategory;
        private NumericUpDown Price;
        private NumericUpDown Amount;
        private Panel panel1;
        private Label label1;
        private Label category;
        private Label quantity;
        private Label name;
        private Label mPrice;
        private Button save;
    }
}