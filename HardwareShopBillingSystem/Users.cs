using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HardwareShopBillingSystem
{
    public partial class Users : Form
    {
        private DatabaseManager dbManager;
       

        public Users()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
            dbManager = new DatabaseManager(connectionString);
        }

        private void LoadUserData()
        {
            try
            {
                DataTable dataTable = dbManager.SelectData("userTb");
                userDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

    

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = tbUserName.Text;
                string userPassword = tbUserPass.Text;
                string userRole = roleBox.Text;

                Dictionary<string, object> fieldValues = new Dictionary<string, object>
                {
                    { "Username", userName },
                    { "Password", userPassword },
                    { "Role", userRole }
                };

                int rowsAffected = dbManager.InsertData("userTb", fieldValues);
                LoadUserData();
                MessageBox.Show("User added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected user's ID
                if (userDataGridView.SelectedRows.Count > 0)
                {
                    int userId = Convert.ToInt32(userDataGridView.SelectedRows[0].Cells["Id"].Value);

                    // Gather updated user information
                    string userName = tbUserName.Text;
                    string userPassword = tbUserPass.Text;
                    string userRole = roleBox.Text;

                    Dictionary<string, object> fieldValues = new Dictionary<string, object>
            {
                { "Username", userName },
                { "Password", userPassword },
                { "Role", userRole }
            };

                    // Update the user record in the database
                    int rowsAffected = dbManager.UpdateData("userTb", userId, "Id", fieldValues);

                    // Reload user data after update
                    LoadUserData();

                    MessageBox.Show("User updated successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a user to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get selected user's ID
                if (userDataGridView.SelectedRows.Count > 0)
                {
                    int userId = Convert.ToInt32(userDataGridView.SelectedRows[0].Cells["Id"].Value);

                    // Delete the user record from the database
                    int rowsAffected = dbManager.DeleteData("userTb", userId, "Id");

                    // Reload user data after deletion
                    LoadUserData();

                    MessageBox.Show("User deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        private void ClearInputFields()
        {
            tbUserName.Text = "";
            tbUserPass.Text = "";
            roleBox.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
