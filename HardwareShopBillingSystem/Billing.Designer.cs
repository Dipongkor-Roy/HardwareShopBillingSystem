namespace HardwareShopBillingSystem
{
    partial class Billing
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelUserName = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            Quantity = new Label();
            label10 = new Label();
            tbProductPrice = new TextBox();
            btnAddtoBill = new Button();
            tbProductName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            reset = new Button();
            btnPrintBill = new Button();
            tbProductCompany = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            tbProductQuantity = new TextBox();
            billDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billDataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.FromArgb(192, 255, 192);
            labelUserName.Location = new Point(20, 197);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(122, 18);
            labelUserName.TabIndex = 40;
            labelUserName.Text = "Product Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(164, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(729, 27);
            textBox2.TabIndex = 38;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Location = new Point(20, 299);
            label8.Name = "label8";
            label8.Size = new Size(47, 18);
            label8.TabIndex = 43;
            label8.Text = "Price";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.BackColor = Color.FromArgb(192, 255, 192);
            Quantity.Location = new Point(237, 197);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(79, 18);
            Quantity.TabIndex = 41;
            Quantity.Text = "Quantity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(192, 255, 192);
            label10.Location = new Point(237, 299);
            label10.Name = "label10";
            label10.Size = new Size(83, 18);
            label10.TabIndex = 47;
            label10.Text = "Company";
            // 
            // tbProductPrice
            // 
            tbProductPrice.Location = new Point(20, 334);
            tbProductPrice.Name = "tbProductPrice";
            tbProductPrice.Size = new Size(195, 27);
            tbProductPrice.TabIndex = 42;
            // 
            // btnAddtoBill
            // 
            btnAddtoBill.BackColor = Color.FromArgb(255, 128, 0);
            btnAddtoBill.FlatAppearance.BorderSize = 0;
            btnAddtoBill.FlatStyle = FlatStyle.Flat;
            btnAddtoBill.Location = new Point(20, 406);
            btnAddtoBill.Name = "btnAddtoBill";
            btnAddtoBill.Size = new Size(195, 38);
            btnAddtoBill.TabIndex = 48;
            btnAddtoBill.Text = "Add To Bill";
            btnAddtoBill.UseVisualStyleBackColor = false;
            btnAddtoBill.Click += btnAddtoBill_Click;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(20, 235);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(195, 27);
            tbProductName.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Verdana", 12F);
            label13.Location = new Point(464, 69);
            label13.Name = "label13";
            label13.Size = new Size(105, 18);
            label13.TabIndex = 55;
            label13.Text = "Billing Page";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(1031, 23);
            label12.Name = "label12";
            label12.Size = new Size(27, 26);
            label12.TabIndex = 53;
            label12.Text = "X";
            label12.Click += label12_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Verdana", 16F);
            label11.Location = new Point(649, 139);
            label11.Name = "label11";
            label11.Size = new Size(158, 26);
            label11.TabIndex = 51;
            label11.Text = "Customer Bill";
            // 
            // reset
            // 
            reset.BackColor = Color.Red;
            reset.FlatAppearance.BorderSize = 0;
            reset.FlatStyle = FlatStyle.Flat;
            reset.ForeColor = Color.White;
            reset.Location = new Point(237, 406);
            reset.Name = "reset";
            reset.Size = new Size(195, 38);
            reset.TabIndex = 50;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.FromArgb(192, 255, 192);
            btnPrintBill.FlatAppearance.BorderSize = 0;
            btnPrintBill.FlatStyle = FlatStyle.Flat;
            btnPrintBill.Location = new Point(649, 944);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(211, 50);
            btnPrintBill.TabIndex = 49;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // tbProductCompany
            // 
            tbProductCompany.Location = new Point(237, 334);
            tbProductCompany.Name = "tbProductCompany";
            tbProductCompany.Size = new Size(195, 27);
            tbProductCompany.TabIndex = 46;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // DataGridView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView.ColumnHeadersHeight = 4;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridView.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView.Location = new Point(20, 479);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new Size(421, 457);
            DataGridView.TabIndex = 56;
            DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView.ThemeStyle.BackColor = Color.White;
            DataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView.ThemeStyle.HeaderStyle.Height = 4;
            DataGridView.ThemeStyle.ReadOnly = false;
            DataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView.ThemeStyle.RowsStyle.Height = 29;
            DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            // 
            // tbProductQuantity
            // 
            tbProductQuantity.Location = new Point(237, 235);
            tbProductQuantity.Name = "tbProductQuantity";
            tbProductQuantity.Size = new Size(195, 27);
            tbProductQuantity.TabIndex = 57;
            // 
            // billDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            billDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            billDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            billDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            billDataGridView.ColumnHeadersHeight = 4;
            billDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            billDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            billDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            billDataGridView.Location = new Point(464, 197);
            billDataGridView.Name = "billDataGridView";
            billDataGridView.RowHeadersVisible = false;
            billDataGridView.RowHeadersWidth = 51;
            billDataGridView.RowTemplate.Height = 29;
            billDataGridView.Size = new Size(601, 739);
            billDataGridView.TabIndex = 58;
            billDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            billDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            billDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            billDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            billDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            billDataGridView.ThemeStyle.BackColor = Color.White;
            billDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            billDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            billDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            billDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            billDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            billDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            billDataGridView.ThemeStyle.ReadOnly = false;
            billDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            billDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            billDataGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            billDataGridView.ThemeStyle.RowsStyle.Height = 29;
            billDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            billDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 1006);
            Controls.Add(billDataGridView);
            Controls.Add(tbProductQuantity);
            Controls.Add(DataGridView);
            Controls.Add(labelUserName);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(Quantity);
            Controls.Add(label10);
            Controls.Add(tbProductPrice);
            Controls.Add(btnAddtoBill);
            Controls.Add(tbProductName);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(reset);
            Controls.Add(btnPrintBill);
            Controls.Add(tbProductCompany);
            Font = new Font("Verdana", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)billDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserName;
        private TextBox textBox2;
        private Label label8;
        private Label Quantity;
        private Label label10;
        private TextBox tbProductPrice;
        private Button btnAddtoBill;
        private TextBox tbProductName;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button reset;
        private Button btnPrintBill;
        private TextBox tbProductCompany;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private TextBox tbProductQuantity;
        private Guna.UI2.WinForms.Guna2DataGridView billDataGridView;
    }
}