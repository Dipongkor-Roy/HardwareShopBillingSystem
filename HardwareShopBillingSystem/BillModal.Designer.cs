namespace HardwareShopBillingSystem
{
    partial class BillModal
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox2 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtTotalBill = new Label();
            txtVat = new Label();
            tbDiscount = new TextBox();
            txtDiscount = new Label();
            billLabel = new Label();
            vatLabel = new Label();
            btnSubmit = new Button();
            button1 = new Button();
            txtBillBy = new Label();
            BillbyLabel = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(63, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(454, 27);
            textBox2.TabIndex = 56;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Verdana", 12F);
            label13.Location = new Point(224, 47);
            label13.Name = "label13";
            label13.Size = new Size(105, 18);
            label13.TabIndex = 59;
            label13.Text = "Billing Page";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(802, 34);
            label12.Name = "label12";
            label12.Size = new Size(27, 26);
            label12.TabIndex = 58;
            label12.Text = "X";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Verdana", 16F);
            label11.Location = new Point(195, 100);
            label11.Name = "label11";
            label11.Size = new Size(158, 26);
            label11.TabIndex = 57;
            label11.Text = "Customer Bill";
            // 
            // txtTotalBill
            // 
            txtTotalBill.AutoSize = true;
            txtTotalBill.BackColor = Color.FromArgb(192, 255, 192);
            txtTotalBill.Font = new Font("Verdana", 12F);
            txtTotalBill.Location = new Point(113, 225);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.Size = new Size(93, 18);
            txtTotalBill.TabIndex = 60;
            txtTotalBill.Text = "Total Bill: ";
            // 
            // txtVat
            // 
            txtVat.AutoSize = true;
            txtVat.BackColor = Color.FromArgb(192, 255, 192);
            txtVat.Font = new Font("Verdana", 12F);
            txtVat.Location = new Point(113, 270);
            txtVat.Name = "txtVat";
            txtVat.Size = new Size(126, 18);
            txtVat.TabIndex = 61;
            txtVat.Text = "Vat(incld tax):";
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(218, 314);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(195, 27);
            tbDiscount.TabIndex = 62;
            // 
            // txtDiscount
            // 
            txtDiscount.AutoSize = true;
            txtDiscount.BackColor = Color.FromArgb(192, 255, 192);
            txtDiscount.Font = new Font("Verdana", 12F);
            txtDiscount.Location = new Point(113, 317);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(79, 18);
            txtDiscount.TabIndex = 63;
            txtDiscount.Text = "Discount";
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.BackColor = Color.FromArgb(192, 255, 192);
            billLabel.Font = new Font("Verdana", 12F);
            billLabel.Location = new Point(223, 225);
            billLabel.Name = "billLabel";
            billLabel.Size = new Size(18, 18);
            billLabel.TabIndex = 64;
            billLabel.Text = "0";
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.BackColor = Color.FromArgb(192, 255, 192);
            vatLabel.Font = new Font("Verdana", 12F);
            vatLabel.Location = new Point(271, 270);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new Size(18, 18);
            vatLabel.TabIndex = 65;
            vatLabel.Text = "0";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(192, 255, 192);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(191, 563);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(211, 50);
            btnSubmit.TabIndex = 66;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(218, 362);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 67;
            button1.Text = "Discount";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBillBy
            // 
            txtBillBy.AutoSize = true;
            txtBillBy.BackColor = Color.FromArgb(192, 255, 192);
            txtBillBy.Font = new Font("Verdana", 12F);
            txtBillBy.Location = new Point(109, 431);
            txtBillBy.Name = "txtBillBy";
            txtBillBy.Size = new Size(67, 18);
            txtBillBy.TabIndex = 68;
            txtBillBy.Text = "Bill By:";
            // 
            // BillbyLabel
            // 
            BillbyLabel.AutoSize = true;
            BillbyLabel.BackColor = Color.FromArgb(192, 255, 192);
            BillbyLabel.Font = new Font("Verdana", 12F);
            BillbyLabel.Location = new Point(191, 431);
            BillbyLabel.Name = "BillbyLabel";
            BillbyLabel.Size = new Size(48, 18);
            BillbyLabel.TabIndex = 69;
            BillbyLabel.Text = "none";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Checked = true;
            DateTimePicker.CustomizableEdges = customizableEdges1;
            DateTimePicker.FillColor = Color.White;
            DateTimePicker.Font = new Font("Segoe UI", 9F);
            DateTimePicker.Format = DateTimePickerFormat.Long;
            DateTimePicker.Location = new Point(109, 465);
            DateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DateTimePicker.Size = new Size(200, 36);
            DateTimePicker.TabIndex = 70;
            DateTimePicker.Value = new DateTime(2024, 5, 14, 0, 12, 22, 569);
            // 
            // BillModal
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(601, 664);
            Controls.Add(DateTimePicker);
            Controls.Add(BillbyLabel);
            Controls.Add(txtBillBy);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(vatLabel);
            Controls.Add(billLabel);
            Controls.Add(txtDiscount);
            Controls.Add(tbDiscount);
            Controls.Add(txtVat);
            Controls.Add(txtTotalBill);
            Controls.Add(textBox2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BillModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label txtTotalBill;
        private Label txtVat;
        private TextBox tbDiscount;
        private Label txtDiscount;
        private Label billLabel;
        private Label vatLabel;
        private Button btnSubmit;
        private Button button1;
        private Label txtBillBy;
        private Label BillbyLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
    }
}