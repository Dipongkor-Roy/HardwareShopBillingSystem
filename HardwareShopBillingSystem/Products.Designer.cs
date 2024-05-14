
namespace HardwareShopBillingSystem
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            textBox2 = new TextBox();
            tbProductName = new TextBox();
            labelUserName = new Label();
            label7 = new Label();
            label8 = new Label();
            tbProductPrice = new TextBox();
            label9 = new Label();
            tbProductQuantity = new TextBox();
            label10 = new Label();
            tbProductCompany = new TextBox();
            btnProductUpdate = new Button();
            btnProductAdd = new Button();
            btnProductDel = new Button();
            label11 = new Label();
            DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            btnWindowClose = new Label();
            label13 = new Label();
            tbProductCategory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(171, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(729, 32);
            textBox2.TabIndex = 18;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(29, 175);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(239, 32);
            tbProductName.TabIndex = 19;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.FromArgb(192, 255, 192);
            labelUserName.Location = new Point(29, 137);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(153, 25);
            labelUserName.TabIndex = 20;
            labelUserName.Text = "Product Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 192);
            label7.Location = new Point(290, 137);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 22;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Location = new Point(547, 137);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 24;
            label8.Text = "Price";
            // 
            // tbProductPrice
            // 
            tbProductPrice.Location = new Point(547, 175);
            tbProductPrice.Name = "tbProductPrice";
            tbProductPrice.Size = new Size(239, 32);
            tbProductPrice.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 255, 192);
            label9.Location = new Point(814, 137);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 26;
            label9.Text = "Quantity";
            // 
            // tbProductQuantity
            // 
            tbProductQuantity.Location = new Point(814, 175);
            tbProductQuantity.Name = "tbProductQuantity";
            tbProductQuantity.Size = new Size(239, 32);
            tbProductQuantity.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(192, 255, 192);
            label10.Location = new Point(29, 235);
            label10.Name = "label10";
            label10.Size = new Size(106, 25);
            label10.TabIndex = 28;
            label10.Text = "Company";
            // 
            // tbProductCompany
            // 
            tbProductCompany.Location = new Point(29, 273);
            tbProductCompany.Name = "tbProductCompany";
            tbProductCompany.Size = new Size(239, 32);
            tbProductCompany.TabIndex = 27;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.BackColor = Color.FromArgb(192, 255, 192);
            btnProductUpdate.FlatAppearance.BorderSize = 0;
            btnProductUpdate.FlatStyle = FlatStyle.Flat;
            btnProductUpdate.Location = new Point(74, 346);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(195, 38);
            btnProductUpdate.TabIndex = 29;
            btnProductUpdate.Text = "Update";
            btnProductUpdate.UseVisualStyleBackColor = false;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnProductAdd.FlatAppearance.BorderSize = 0;
            btnProductAdd.FlatStyle = FlatStyle.Flat;
            btnProductAdd.Location = new Point(443, 346);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(195, 38);
            btnProductAdd.TabIndex = 30;
            btnProductAdd.Text = "Add Item";
            btnProductAdd.UseVisualStyleBackColor = false;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // btnProductDel
            // 
            btnProductDel.BackColor = Color.Red;
            btnProductDel.FlatAppearance.BorderSize = 0;
            btnProductDel.FlatStyle = FlatStyle.Flat;
            btnProductDel.ForeColor = Color.White;
            btnProductDel.Location = new Point(816, 346);
            btnProductDel.Name = "btnProductDel";
            btnProductDel.Size = new Size(195, 38);
            btnProductDel.TabIndex = 31;
            btnProductDel.Text = "Delete";
            btnProductDel.UseVisualStyleBackColor = false;
            btnProductDel.Click += btnProductDel_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Verdana", 16F);
            label11.Location = new Point(452, 426);
            label11.Name = "label11";
            label11.Size = new Size(174, 32);
            label11.TabIndex = 32;
            label11.Text = "Product List";
            // 
            // DataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView.ColumnHeadersHeight = 4;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView.Location = new Point(29, 483);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(1025, 497);
            DataGridView.TabIndex = 33;
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
            // 
            // btnWindowClose
            // 
            btnWindowClose.AutoSize = true;
            btnWindowClose.BackColor = Color.White;
            btnWindowClose.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWindowClose.ForeColor = Color.Red;
            btnWindowClose.Location = new Point(1039, 9);
            btnWindowClose.Name = "btnWindowClose";
            btnWindowClose.Size = new Size(34, 34);
            btnWindowClose.TabIndex = 34;
            btnWindowClose.Text = "X";
            btnWindowClose.Click += btnWindowClose_Click_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Verdana", 12F);
            label13.Location = new Point(465, 55);
            label13.Name = "label13";
            label13.Size = new Size(143, 25);
            label13.TabIndex = 36;
            label13.Text = "Products Add";
            // 
            // tbProductCategory
            // 
            tbProductCategory.Location = new Point(290, 175);
            tbProductCategory.Name = "tbProductCategory";
            tbProductCategory.Size = new Size(223, 32);
            tbProductCategory.TabIndex = 37;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 1006);
            Controls.Add(tbProductCategory);
            Controls.Add(label13);
            Controls.Add(btnWindowClose);
            Controls.Add(DataGridView);
            Controls.Add(label11);
            Controls.Add(btnProductDel);
            Controls.Add(btnProductAdd);
            Controls.Add(btnProductUpdate);
            Controls.Add(label10);
            Controls.Add(tbProductCompany);
            Controls.Add(label9);
            Controls.Add(tbProductQuantity);
            Controls.Add(label8);
            Controls.Add(tbProductPrice);
            Controls.Add(label7);
            Controls.Add(labelUserName);
            Controls.Add(tbProductName);
            Controls.Add(textBox2);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load_1;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox textBox2;
        private TextBox tbProductName;
        private Label label10;
        private TextBox tbProductCompany;
        private Label label9;
        private TextBox tbProductQuantity;
        private Label label8;
        private TextBox tbProductPrice;
        private Label label7;
        private Label labelUserName;
        private Button btnProductDel;
        private Button btnProductAdd;
        private Button btnProductUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Label label11;
        private Label btnWindowClose;
        private Label label13;
        private TextBox tbProductCategory;
    }
}