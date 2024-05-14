namespace HardwareShopBillingSystem
{
    partial class BillingList
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
            billDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            labelUserName = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            revenueLable = new Label();
            ((System.ComponentModel.ISupportInitialize)billDataGridView).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
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
            billDataGridView.Location = new Point(125, 253);
            billDataGridView.Name = "billDataGridView";
            billDataGridView.RowHeadersVisible = false;
            billDataGridView.RowHeadersWidth = 51;
            billDataGridView.RowTemplate.Height = 29;
            billDataGridView.Size = new Size(729, 484);
            billDataGridView.TabIndex = 75;
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
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.FromArgb(192, 255, 192);
            labelUserName.Font = new Font("Verdana", 16F);
            labelUserName.Location = new Point(394, 124);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(177, 26);
            labelUserName.TabIndex = 61;
            labelUserName.Text = "Total Revenue:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(125, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(729, 27);
            textBox2.TabIndex = 59;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Verdana", 12F);
            label13.Location = new Point(442, 50);
            label13.Name = "label13";
            label13.Size = new Size(95, 18);
            label13.TabIndex = 72;
            label13.Text = "Billing List";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(870, 21);
            label12.Name = "label12";
            label12.Size = new Size(27, 26);
            label12.TabIndex = 71;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Verdana", 16F);
            label11.Location = new Point(444, 224);
            label11.Name = "label11";
            label11.Size = new Size(91, 26);
            label11.TabIndex = 70;
            label11.Text = "Bill List";
            // 
            // revenueLable
            // 
            revenueLable.AutoSize = true;
            revenueLable.BackColor = Color.FromArgb(192, 255, 192);
            revenueLable.Font = new Font("Verdana", 16F);
            revenueLable.Location = new Point(566, 124);
            revenueLable.Name = "revenueLable";
            revenueLable.Size = new Size(26, 26);
            revenueLable.TabIndex = 76;
            revenueLable.Text = "0";
            // 
            // BillingList
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 1006);
            Controls.Add(revenueLable);
            Controls.Add(billDataGridView);
            Controls.Add(labelUserName);
            Controls.Add(textBox2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BillingList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillingList";
            Load += BillingList_Load;
            ((System.ComponentModel.ISupportInitialize)billDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView billDataGridView;
        private Label labelUserName;
        private TextBox textBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label revenueLable;
    }
}