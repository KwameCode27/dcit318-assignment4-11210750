namespace Pharmacy
{
    partial class RecordSale
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
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            save = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(280, 63);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 3;
            label2.Text = "Sold Quantity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(259, 96);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(156, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(60, 63);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 1;
            label1.Text = "Choose The Medicine";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(save);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(78, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 187);
            panel1.TabIndex = 5;
            // 
            // save
            // 
            save.Location = new Point(193, 141);
            save.Name = "save";
            save.Size = new Size(79, 23);
            save.TabIndex = 5;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(193, 22);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 4;
            label3.Text = "Record Sale";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 0;
            // 
            // RecordSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 268);
            Controls.Add(panel1);
            Name = "RecordSale";
            Text = "RecordSale";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Panel panel1;
        private Button save;
        private Label label3;
        private ComboBox comboBox1;
    }
}