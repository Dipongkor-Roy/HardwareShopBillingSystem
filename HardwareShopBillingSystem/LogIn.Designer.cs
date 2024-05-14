namespace HardwareShopBillingSystem
{
    partial class LogIn
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            textBox1 = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            btnLogIn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 870);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT Poster Compressed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(732, 111);
            label1.Name = "label1";
            label1.Size = new Size(150, 39);
            label1.TabIndex = 1;
            label1.Text = "Hardware Shop";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 255, 192);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Desktop;
            textBox1.Location = new Point(712, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 32);
            textBox1.TabIndex = 2;
            textBox1.Text = "Billing System";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(584, 369);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 32);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(584, 485);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 32);
            txtPassword.TabIndex = 4;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.FromArgb(192, 255, 192);
            labelUserName.Location = new Point(584, 316);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(114, 25);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.FromArgb(192, 255, 192);
            labelPassword.Location = new Point(584, 439);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(105, 25);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(584, 541);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 7;
            guna2HtmlLabel1.Text = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.motherboard;
            pictureBox1.Location = new Point(584, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(192, 255, 192);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Location = new Point(652, 559);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(195, 38);
            btnLogIn.TabIndex = 11;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1008, 32);
            label2.Name = "label2";
            label2.Size = new Size(34, 34);
            label2.TabIndex = 13;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 870);
            Controls.Add(label2);
            Controls.Add(btnLogIn);
            Controls.Add(pictureBox1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label labelPassword;
        private Label labelUserName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Button btnLogIn;
        private Label label2;
    }
}
