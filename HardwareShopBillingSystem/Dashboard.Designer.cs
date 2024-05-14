namespace HardwareShopBillingSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnLogOut = new Label();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            textBox1 = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            btnBilling = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            btnproductList = new Label();
            btnProducts = new Label();
            pictureBox6 = new PictureBox();
            billlistpannel = new Panel();
            btnBillList = new Label();
            imgbillList = new PictureBox();
            panUser = new Panel();
            btnUsers = new Label();
            userLogo = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dashboardPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            billlistpannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgbillList).BeginInit();
            panUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.BackColor = Color.FromArgb(0, 192, 0);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Verdana", 17F);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(83, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(103, 28);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "Log Out";
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(billlistpannel);
            panel1.Controls.Add(panUser);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 1006);
            panel1.TabIndex = 38;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.motherboard;
            pictureBox7.Location = new Point(12, 36);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(86, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Desktop;
            textBox1.Location = new Point(0, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 27);
            textBox1.TabIndex = 17;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT Poster Compressed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 49);
            label6.Name = "label6";
            label6.Size = new Size(119, 31);
            label6.TabIndex = 16;
            label6.Text = "Hardware Shop";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Controls.Add(btnBilling);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(12, 572);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 43);
            panel4.TabIndex = 15;
            // 
            // btnBilling
            // 
            btnBilling.AutoSize = true;
            btnBilling.BackColor = Color.FromArgb(0, 192, 0);
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Verdana", 17F);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(83, 3);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(81, 28);
            btnBilling.TabIndex = 12;
            btnBilling.Text = "Billing";
            btnBilling.Click += btnBilling_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(12, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 43);
            panel3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 17F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 3);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 12;
            label1.Text = "Dashboard";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 192, 0);
            panel7.Controls.Add(btnproductList);
            panel7.Controls.Add(btnProducts);
            panel7.Controls.Add(pictureBox6);
            panel7.Location = new Point(12, 312);
            panel7.Name = "panel7";
            panel7.Size = new Size(241, 43);
            panel7.TabIndex = 14;
            // 
            // btnproductList
            // 
            btnproductList.AutoSize = true;
            btnproductList.BackColor = Color.FromArgb(0, 192, 0);
            btnproductList.FlatStyle = FlatStyle.Flat;
            btnproductList.Font = new Font("Verdana", 15F);
            btnproductList.ForeColor = Color.White;
            btnproductList.Location = new Point(76, 5);
            btnproductList.Name = "btnproductList";
            btnproductList.Size = new Size(130, 25);
            btnproductList.TabIndex = 13;
            btnproductList.Text = "Product List";
            btnproductList.Click += btnproductList_Click;
            // 
            // btnProducts
            // 
            btnProducts.AutoSize = true;
            btnProducts.BackColor = Color.FromArgb(0, 192, 0);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Verdana", 17F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(83, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(112, 28);
            btnProducts.TabIndex = 12;
            btnProducts.Text = "Products";
            btnProducts.Click += btnProducts_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(13, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // billlistpannel
            // 
            billlistpannel.BackColor = Color.FromArgb(0, 192, 0);
            billlistpannel.Controls.Add(btnBillList);
            billlistpannel.Controls.Add(imgbillList);
            billlistpannel.Location = new Point(12, 396);
            billlistpannel.Name = "billlistpannel";
            billlistpannel.Size = new Size(241, 43);
            billlistpannel.TabIndex = 13;
            // 
            // btnBillList
            // 
            btnBillList.AutoSize = true;
            btnBillList.BackColor = Color.FromArgb(0, 192, 0);
            btnBillList.FlatStyle = FlatStyle.Flat;
            btnBillList.Font = new Font("Verdana", 17F);
            btnBillList.ForeColor = Color.White;
            btnBillList.Location = new Point(72, 3);
            btnBillList.Name = "btnBillList";
            btnBillList.Size = new Size(94, 28);
            btnBillList.TabIndex = 12;
            btnBillList.Text = "Bill List";
            btnBillList.Click += btnCategories_Click;
            // 
            // imgbillList
            // 
            imgbillList.Image = (Image)resources.GetObject("imgbillList.Image");
            imgbillList.Location = new Point(13, 3);
            imgbillList.Name = "imgbillList";
            imgbillList.Size = new Size(64, 35);
            imgbillList.SizeMode = PictureBoxSizeMode.Zoom;
            imgbillList.TabIndex = 11;
            imgbillList.TabStop = false;
            // 
            // panUser
            // 
            panUser.BackColor = Color.FromArgb(0, 192, 0);
            panUser.Controls.Add(btnUsers);
            panUser.Controls.Add(userLogo);
            panUser.Location = new Point(12, 483);
            panUser.Name = "panUser";
            panUser.Size = new Size(241, 43);
            panUser.TabIndex = 5;
            // 
            // btnUsers
            // 
            btnUsers.AutoSize = true;
            btnUsers.BackColor = Color.FromArgb(0, 192, 0);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Verdana", 17F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(72, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(77, 28);
            btnUsers.TabIndex = 12;
            btnUsers.Text = "Users";
            btnUsers.Click += btnUsers_Click;
            // 
            // userLogo
            // 
            userLogo.Image = (Image)resources.GetObject("userLogo.Image");
            userLogo.Location = new Point(13, 3);
            userLogo.Name = "userLogo";
            userLogo.Size = new Size(64, 35);
            userLogo.SizeMode = PictureBoxSizeMode.Zoom;
            userLogo.TabIndex = 11;
            userLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 945);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 43);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Dock = DockStyle.Right;
            dashboardPanel.Location = new Point(272, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1087, 1006);
            dashboardPanel.TabIndex = 56;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1359, 1006);
            Controls.Add(dashboardPanel);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            billlistpannel.ResumeLayout(false);
            billlistpannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgbillList).EndInit();
            panUser.ResumeLayout(false);
            panUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label btnLogOut;
        private Panel panel1;
        private PictureBox pictureBox7;
        private TextBox textBox1;
        private Label label6;
        private Panel panel4;
        private Label btnBilling;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Label btnProducts;
        private PictureBox pictureBox6;
        private Panel billlistpannel;
        private Label btnBillList;
        private PictureBox imgbillList;
        private Panel panUser;
        private Label btnUsers;
        private PictureBox userLogo;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel dashboardPanel;
        private Label btnproductList;
    }
}