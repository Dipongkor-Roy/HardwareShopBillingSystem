namespace HardwareShopBillingSystem
{
    partial class Users
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            userDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            tbUserPass = new TextBox();
            labelUserName = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            Quantity = new Label();
            btnAddUser = new Button();
            tbUserName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnDelete = new Button();
            roleBox = new Guna.UI2.WinForms.Guna2ComboBox();
            btnUpdateUser = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userDataGridView.ColumnHeadersHeight = 4;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            userDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            userDataGridView.Location = new Point(358, 192);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersVisible = false;
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.RowTemplate.Height = 29;
            userDataGridView.Size = new Size(430, 473);
            userDataGridView.TabIndex = 75;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            userDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            userDataGridView.ThemeStyle.BackColor = Color.White;
            userDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            userDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            userDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            userDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            userDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            userDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            userDataGridView.ThemeStyle.ReadOnly = false;
            userDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            userDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userDataGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            userDataGridView.ThemeStyle.RowsStyle.Height = 29;
            userDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            userDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            userDataGridView.CellContentClick += userDataGridView_CellContentClick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // tbUserPass
            // 
            tbUserPass.Location = new Point(27, 334);
            tbUserPass.Name = "tbUserPass";
            tbUserPass.Size = new Size(195, 27);
            tbUserPass.TabIndex = 74;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.FromArgb(192, 255, 192);
            labelUserName.Location = new Point(27, 192);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(55, 18);
            labelUserName.TabIndex = 61;
            labelUserName.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Desktop;
            textBox2.Location = new Point(27, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(729, 27);
            textBox2.TabIndex = 59;
            textBox2.Text = "Welcome";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 255, 192);
            label8.Location = new Point(27, 399);
            label8.Name = "label8";
            label8.Size = new Size(44, 18);
            label8.TabIndex = 64;
            label8.Text = "Role";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.BackColor = Color.FromArgb(192, 255, 192);
            Quantity.Location = new Point(27, 295);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(85, 18);
            Quantity.TabIndex = 62;
            Quantity.Text = "Password";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(255, 128, 0);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(27, 511);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(143, 38);
            btnAddUser.TabIndex = 67;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(27, 231);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(195, 27);
            tbUserName.TabIndex = 60;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 192);
            label13.Font = new Font("Verdana", 12F);
            label13.Location = new Point(348, 59);
            label13.Name = "label13";
            label13.Size = new Size(100, 18);
            label13.TabIndex = 72;
            label13.Text = "Users Page";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(789, 19);
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
            label11.Location = new Point(525, 151);
            label11.Name = "label11";
            label11.Size = new Size(107, 26);
            label11.TabIndex = 70;
            label11.Text = "All Users";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(185, 511);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 38);
            btnDelete.TabIndex = 69;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // roleBox
            // 
            roleBox.BackColor = Color.Transparent;
            roleBox.CustomizableEdges = customizableEdges1;
            roleBox.DisplayMember = "Admin";
            roleBox.DrawMode = DrawMode.OwnerDrawFixed;
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.FocusedColor = Color.FromArgb(94, 148, 255);
            roleBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            roleBox.Font = new Font("Segoe UI", 10F);
            roleBox.ForeColor = Color.FromArgb(68, 88, 112);
            roleBox.ItemHeight = 30;
            roleBox.Items.AddRange(new object[] { "Admin", "User" });
            roleBox.Location = new Point(27, 437);
            roleBox.Name = "roleBox";
            roleBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            roleBox.Size = new Size(195, 36);
            roleBox.TabIndex = 76;
            roleBox.ValueMember = "None";
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Location = new Point(27, 567);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(143, 38);
            btnUpdateUser.TabIndex = 77;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 1006);
            Controls.Add(btnUpdateUser);
            Controls.Add(roleBox);
            Controls.Add(userDataGridView);
            Controls.Add(tbUserPass);
            Controls.Add(labelUserName);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(Quantity);
            Controls.Add(btnAddUser);
            Controls.Add(tbUserName);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnDelete);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView userDataGridView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox tbUserPass;
        private Label labelUserName;
        private TextBox textBox2;
        private Label label8;
        private Label Quantity;
        private Button btnAddUser;
        private TextBox tbUserName;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnDelete;
        private Guna.UI2.WinForms.Guna2ComboBox roleBox;
        private Button btnUpdateUser;
    }
}