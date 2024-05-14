using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShopBillingSystem
{
    public partial class Dashboard : Form
    {
        private Products? productsForm;
        private Billing? billingForm;
        private ProductList? productListForm;
        private BillingList? billingListForm;
        private Users? usersForm;
        private string currentUserRole; // Store current user's role

        public Dashboard(string role)
        {
            InitializeComponent();
            // Initialize DatabaseManager with connection string

            this.currentUserRole = role;
            SetButtonVisibility(); // Set button visibility based on user role
        }




        // Method to set button visibility based on user role
        private void SetButtonVisibility()
        {
            if (currentUserRole == "Admin")
            {

                btnProducts.Visible = true;
                btnBillList.Visible = true;
                btnUsers.Visible = true;
                btnBilling.Visible = true;
                /* btnProductAdd.Visible = true;
                 btnProductDel.Visible = true;
                 btnProductUpdate.Visible = true;*/
                btnproductList.Visible = false;
            }
            else if (currentUserRole == "User")
            {
                btnProducts.Visible = false;
                btnBillList.Visible = false;
                btnUsers.Visible = false;
                btnBilling.Visible = true;
                /*btnProductAdd.Visible = false;
                btnProductDel.Visible = false;
                btnProductUpdate.Visible = false;*/
                panUser.Visible = false;
                btnUsers.Visible = false;
                userLogo.Visible = false;
                btnproductList.Visible = true;
                billlistpannel.Visible= false;
                imgbillList.Visible = false;

            }
        }

        // Event handler for opening a form (e.g., add product form)
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Implement code to open the add product form or perform related action
            MessageBox.Show("Add Product functionality goes here.");
        }

        // Other button click event handlers can be similarly implemented...

        // Example event handler for logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the dashboard form upon logout
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (productsForm == null || productsForm.IsDisposed)
            {
                // Create a new instance of the Products form
                productsForm = new Products();

                // Set the Products form to fill the dashboardPanel
                productsForm.TopLevel = false;
                productsForm.FormBorderStyle = FormBorderStyle.None;
                productsForm.Dock = DockStyle.Fill;

                // Add the Products form to the dashboardPanel
                dashboardPanel.Controls.Clear(); // Clear existing controls from the panel
                dashboardPanel.Controls.Add(productsForm);

                // Display the Products form
                productsForm.Show();
            }
            else
            {
                // Bring the existing Products form to the front if it's already displayed
                productsForm.BringToFront();
            }
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close(); // Close the current form (Products form)
                LogIn loginForm = new LogIn();
                loginForm.Show(); // Show the login form
            }
        }

        private void btnproductList_Click(object sender, EventArgs e)
        {
            if (productListForm == null || productListForm.IsDisposed)
            {
                // Create a new instance of the ProductList form
                productListForm = new ProductList();

                // Set the ProductList form to fill the dashboardPanel
                productListForm.TopLevel = false;
                productListForm.FormBorderStyle = FormBorderStyle.None;
                productListForm.Dock = DockStyle.Fill;

                // Add the ProductList form to the dashboardPanel
                dashboardPanel.Controls.Clear(); // Clear existing controls from the panel
                dashboardPanel.Controls.Add(productListForm);

                // Display the ProductList form
                productListForm.Show();
            }
            else
            {
                // Bring the existing ProductList form to the front if it's already displayed
                productListForm.BringToFront();
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (billingForm == null || billingForm.IsDisposed)
            {
                // Create a new instance of the Billing form
                billingForm = new Billing();

                // Set the Billing form to fill the dashboardPanel
                billingForm.TopLevel = false;
                billingForm.FormBorderStyle = FormBorderStyle.None;
                billingForm.Dock = DockStyle.Fill;

                // Add the Billing form to the dashboardPanel
                dashboardPanel.Controls.Clear(); // Clear existing controls from the panel
                dashboardPanel.Controls.Add(billingForm);

                // Display the Billing form
                billingForm.Show();
            }
            else
            {
                // Bring the existing Billing form to the front if it's already displayed
                billingForm.BringToFront();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            if (billingListForm == null || billingListForm.IsDisposed)
            {
                // Create a new instance of the Categories form
                billingListForm = new BillingList();

                // Set the Categories form to fill the dashboardPanel
                billingListForm.TopLevel = false;
                billingListForm.FormBorderStyle = FormBorderStyle.None;
                billingListForm.Dock = DockStyle.Fill;

                // Add the Categories form to the dashboardPanel
                dashboardPanel.Controls.Clear(); // Clear existing controls from the panel
                dashboardPanel.Controls.Add(billingListForm);

                // Display the Categories form
                billingListForm.Show();
            }
            else
            {
                // Bring the existing Categories form to the front if it's already displayed
                billingForm.BringToFront();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (usersForm == null || usersForm.IsDisposed)
            {
                // Create a new instance of the Users form
                usersForm = new Users();

                // Set the Users form to fill the dashboardPanel
                usersForm.TopLevel = false;
                usersForm.FormBorderStyle = FormBorderStyle.None;
                usersForm.Dock = DockStyle.Fill;

                // Add the Users form to the dashboardPanel
                dashboardPanel.Controls.Clear(); // Clear existing controls from the panel
                dashboardPanel.Controls.Add(usersForm);

                // Display the Users form
                usersForm.Show();
            }
            else
            {
                // Bring the existing Users form to the front if it's already displayed
                usersForm.BringToFront();
            }
        }
    }
}


