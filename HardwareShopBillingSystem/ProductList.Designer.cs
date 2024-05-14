namespace HardwareShopBillingSystem
{
    partial class ProductList
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
            btnWindowClose = new Label();
            productDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            label11 = new Label();
            textBox2 = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tbinputserach = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnWindowClose
            // 
            btnWindowClose.AutoSize = true;
            btnWindowClose.BackColor = Color.White;
            btnWindowClose.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWindowClose.ForeColor = Color.Red;
            btnWindowClose.Location = new Point(1031, 18);
            btnWindowClose.Name = "btnWindowClose";
            btnWindowClose.Size = new Size(27, 26);
            btnWindowClose.TabIndex = 53;
            btnWindowClose.Text = "X";
            btnWindowClose.Click += btnWindowClose_Click;
            // 
            // productDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            productDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productDataGridView.ColumnHeadersHeight = 4;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            productDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            productDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            productDataGridView.Location = new Point(20, 250);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersVisible = false;
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.RowTemplate.Height = 29;
            productDataGridView.Size = new Size(1045, 734);
            productDataGridView.TabIndex = 52;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            productDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            productDataGridView.ThemeStyle.BackColor = Color.White;
            productDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            productDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            productDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            productDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            productDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            productDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            productDataGridView.ThemeStyle.ReadOnly = false;
            productDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            productDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productDataGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            productDataGridView.ThemeStyle.RowsStyle.Height = 29;
            productDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            productDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Verdana", 16F);
            label11.Location = new Point(449, 201);
            label11.Name = "label11";
            label11.Size = new Size(141, 26);
            label11.TabIndex = 51;
            label11.Text = "Product List";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(163, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(729, 27);
            textBox2.TabIndex = 38;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // tbinputserach
            // 
            tbinputserach.Location = new Point(353, 115);
            tbinputserach.Name = "tbinputserach";
            tbinputserach.Size = new Size(223, 27);
            tbinputserach.TabIndex = 55;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 192);
            btnSearch.Font = new Font("Verdana", 13F);
            btnSearch.Location = new Point(582, 112);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 32);
            btnSearch.TabIndex = 56;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 1006);
            Controls.Add(btnSearch);
            Controls.Add(tbinputserach);
            Controls.Add(btnWindowClose);
            Controls.Add(productDataGridView);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProductList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductList";
            Load += ProductList_Load;
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnWindowClose;
        private Guna.UI2.WinForms.Guna2DataGridView productDataGridView;
        private Label label11;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button btnSearch;
        private TextBox tbinputserach;
    }
}