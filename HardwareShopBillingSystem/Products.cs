using System;
using System.Data;
using System.Windows.Forms;

namespace HardwareShopBillingSystem
{
    public partial class Products : Form
    {
        private DatabaseManager dbManager;
        private int selectedProductCode = -1; // To store the ProductCode of the selected product

        public Products()
        {
            InitializeComponent();
            // Initialize DatabaseManager with connection string
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
            dbManager = new DatabaseManager(connectionString);
        }

        // Method to load product data into DataGridView
        private void LoadProductData()
        {
            try
            {
                DataTable dataTable = dbManager.SelectData("productTb");
                DataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        // Button click event to add a new product
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = tbProductName.Text;
                string productCategory = tbProductCategory.Text;
                double price = double.Parse(tbProductPrice.Text);
                int quantity = Convert.ToInt32(tbProductQuantity.Text);
                string company = tbProductCompany.Text;

                // Prepare field values for insertion
                var fieldValues = new Dictionary<string, object>
        {
            { "Name", productName }, // column names in the database
            { "CategoryName", productCategory },
            { "Price", price },
            { "Quantity", quantity },
            { "Company", company }
        };

                // Execute INSERT query using DatabaseManager
                int rowsInserted = dbManager.InsertData("productTb", fieldValues);

                MessageBox.Show("Product has been added successfully");
                LoadProductData(); // Refresh DataGridView after adding a new product
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        // Button click event to delete a product
        private void btnProductDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductCode != -1)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int rowsDeleted = dbManager.DeleteData("productTb", selectedProductCode, "ProductCode");

                        MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductData(); // Refresh DataGridView after deletion
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        // Button click event to update a product
        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductCode != -1)
                {
                    string productName = tbProductName.Text;
                    string productCategory = tbProductCategory.Text;
                    double price = double.Parse(tbProductPrice.Text);
                    int quantity = Convert.ToInt32(tbProductQuantity.Text);
                    string company = tbProductCompany.Text;

                    var fieldValues = new Dictionary<string, object>
            {
                { "Name", productName },
                { "CategoryName", productCategory },
                { "Price", price },
                { "Quantity", quantity },
                { "Company", company }
            };

                    int rowsUpdated = dbManager.UpdateData("productTb", selectedProductCode, "ProductCode", fieldValues);

                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductData(); // Refresh DataGridView after update
                }
                else
                {
                    MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DataGridView cell click event to capture selected product code
        private void DataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = DataGridView.Rows[e.RowIndex];
                if (selectedRow.DataBoundItem is DataRowView dataRowView)
                {
                    selectedProductCode = Convert.ToInt32(dataRowView["ProductCode"]);
                }
            }
            else
            {
                selectedProductCode = -1;
            }
        }

        // Button click event to clear input fields
        private void ClearInputFields()
        {
            tbProductName.Text = "";
            tbProductCategory.Text = "";
            tbProductPrice.Text = "";
            tbProductQuantity.Text = "";
            tbProductCompany.Text = "";
        }

        // Form load event to initially load product data
        private void Products_Load_1(object sender, EventArgs e)
        {
            DataGridView.CellClick += DataGridView_CellClick;
            LoadProductData();
        }

        // Button click event to close the form
        private void btnWindowClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Button click event to logout
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close(); // Close the current form (Products form)
                LogIn loginForm = new LogIn();
                loginForm.Show(); // Show the login form
            }
        }
    }
}
