using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HardwareShopBillingSystem
{
    public partial class Billing : Form
    {
        private DatabaseManager dbManager;
        private int selectedProductCode = -1;

        private Dictionary<int, int> originalQuantities = new Dictionary<int, int>(); // Dictionary to store original product quantities
        public Billing()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
            dbManager = new DatabaseManager(connectionString);
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            // Add columns to billDataGridView
            billDataGridView.Columns.Add("ProductCode", "Product Code");
            billDataGridView.Columns.Add("ProductName", "Product Name");
            billDataGridView.Columns.Add("Price", "Price");
            billDataGridView.Columns.Add("Quantity", "Quantity");
            billDataGridView.Columns.Add("TotalPrice", "Total Price");
        }
        //data loader
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
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            LoadProductData();
            StoreOriginalQuantities();
        }
        //backup quantity
        private void StoreOriginalQuantities()
        {
            try
            {
                // Retrieve all products and store their original quantities
                DataTable productTable = dbManager.SelectData("productTb");

                if (productTable != null)
                {
                    foreach (DataRow row in productTable.Rows)
                    {
                        int productCode = Convert.ToInt32(row["ProductCode"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);
                        originalQuantities[productCode] = quantity; // Store original quantity in dictionary
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error storing original quantities: " + ex.Message);
            }
        }


        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            // Retrieve product details from input fields
            string productName = tbProductName.Text.Trim();
            double price = double.Parse(tbProductPrice.Text);
            int quantity = Convert.ToInt32(tbProductQuantity.Text);
            string company = tbProductCompany.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(productName) || quantity <= 0 || string.IsNullOrEmpty(company))
            {
                MessageBox.Show("Please provide valid product details.");
                return;
            }

            try
            {
                // Initialize DatabaseManager with connection string


                // Check if the product exists in the database
                DataTable productTable = dbManager.ExecuteQuery($"SELECT * FROM productTb WHERE Name = '{productName}' AND Company = '{company}'");

                // Check if productTable is not null and contains rows
                if (productTable != null && productTable.Rows.Count > 0)
                {
                    DataRow productRow = productTable.Rows[0];

                    // Check if productRow is not null
                    if (productRow != null)
                    {
                        int productCode = productRow.Field<int>("ProductCode");

                        // Retrieve Quantity as integer from DataRow
                        int availableQuantity = productRow.Field<int>("Quantity");


                        // Check if sufficient quantity is available
                        if (quantity > availableQuantity)
                        {
                            MessageBox.Show("Not enough stock available for this product.");
                            return;
                        }

                        // Add product to the bill (DataGridView)
                        billDataGridView.Rows.Add(productCode, productName, price, quantity, price * quantity);

                        // Update product quantity in the database
                        int newQuantity = availableQuantity - quantity;
                        dbManager.ExecuteNonQuery($"UPDATE productTb SET Quantity = @NewQuantity WHERE ProductCode = @ProductCode",
                            new Dictionary<string, object>
                            {
                        { "@NewQuantity", newQuantity },
                        { "@ProductCode", productCode }
                            });

                        // Clear input fields after adding to bill
                        ClearInputFields();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product details not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //clear input fields method

        private void ClearInputFields()
        {
            tbProductName.Text = "";
            tbProductPrice.Text = "";
            tbProductQuantity.Text = "";
            tbProductCompany.Text = "";

        }


        private void reset_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            try
            {
                billDataGridView.Rows.Clear();
                // Reset product quantities in the database to original values
                foreach (var kvp in originalQuantities)
                {
                    int productCode = kvp.Key;
                    int originalQuantity = kvp.Value;

                    // Update product quantity in the database
                    dbManager.ExecuteNonQuery($"UPDATE productTb SET Quantity = @OriginalQuantity WHERE ProductCode = @ProductCode",
                        new Dictionary<string, object>
                        {
                    { "@OriginalQuantity", originalQuantity },
                    { "@ProductCode", productCode }
                        });
                }

                MessageBox.Show("Product quantities have been reset.");
                LoadProductData(); // Refresh product data in the DataGridView after reset
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting product quantities: " + ex.Message);
            }
        }
        private double CalculateTotalBill()
        {
            double totalBill = 0;

            // Calculate sum of TotalPrice column in billDataGridView
            foreach (DataGridViewRow row in billDataGridView.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    totalBill += Convert.ToDouble(row.Cells["TotalPrice"].Value);
                }
            }

            return totalBill;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            double totalBill = CalculateTotalBill();

            // Create and show BillModal
            using (BillModal billModal = new BillModal(totalBill, "User"))
            {
                billModal.ShowDialog();
            }
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
