using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShopBillingSystem
{


    public partial class ProductList : Form
    {
        private DatabaseManager dbManager;
        public ProductList()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
            dbManager = new DatabaseManager(connectionString);

        }
        //loadProduct
        private void LoadProductData()
        {
            try
            {
                DataTable dataTable = dbManager.SelectData("productTb");
                productDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }


        private void ProductList_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = tbinputserach.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchKeyword))
                {
                    // No search keyword provided, load all products
                    LoadProductData();
                }
                else
                {
                    // Search products by product name
                    DataTable dataTable = SearchProductsByName(searchKeyword);
                    productDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable SearchProductsByName(string productName)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
            
            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM productTb WHERE Name LIKE @ProductName";

            using (SqlConnection conn = new SqlConnection(connectionString)) // Use ConnectionString property
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@ProductName", "%" + productName + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

    }
    
    
}
