namespace HardwareShopBillingSystem
{
    partial class DashboardPannel
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
            textBox2 = new TextBox();
            dashboardPanel = new Panel();
            btnWindowClose = new Label();
            label13 = new Label();
            dashboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(199, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(729, 32);
            textBox2.TabIndex = 39;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Controls.Add(textBox2);
            dashboardPanel.Controls.Add(btnWindowClose);
            dashboardPanel.Controls.Add(label13);
            dashboardPanel.Location = new Point(1, 2);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1087, 1004);
            dashboardPanel.TabIndex = 57;
            // 
            // btnWindowClose
            // 
            btnWindowClose.AutoSize = true;
            btnWindowClose.BackColor = Color.White;
            btnWindowClose.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWindowClose.ForeColor = Color.Red;
            btnWindowClose.Location = new Point(1004, 13);
            btnWindowClose.Name = "btnWindowClose";
            btnWindowClose.Size = new Size(34, 34);
            btnWindowClose.TabIndex = 54;
            btnWindowClose.Text = "X";
            btnWindowClose.Click += btnWindowClose_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Verdana", 12F);
            label13.Location = new Point(508, 52);
            label13.Name = "label13";
            label13.Size = new Size(119, 25);
            label13.TabIndex = 55;
            label13.Text = "Dashboard";
            // 
            // DashboardPannel
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 1006);
            Controls.Add(dashboardPanel);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "DashboardPannel";
            Text = "DashboardPannel";
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private Panel dashboardPanel;
        private Label btnWindowClose;
        private Label label13;
    }
}