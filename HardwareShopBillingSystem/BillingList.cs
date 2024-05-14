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
    public partial class BillingList : Form
    {
        private DatabaseManager dbManager;
        public BillingList()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
            dbManager = new DatabaseManager(connectionString);

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void LoadBillingData()
        {
            try
            {
                DataTable dataTable = dbManager.SelectData("billingTb");
                billDataGridView.DataSource = dataTable;
                decimal totalRevenue = CalculateTotalRevenue(dataTable);
                revenueLable.Text = totalRevenue.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }
        //calculate revenue
        private decimal CalculateTotalRevenue(DataTable dataTable)
        {
            decimal totalRevenue = 0;

            // Check if the DataTable contains the 'Amount' column
            if (dataTable.Columns.Contains("Amount"))
            {
                // Loop through each row and sum up the 'Amount' values
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Amount"] != DBNull.Value)
                    {
                        totalRevenue += Convert.ToDecimal(row["Amount"]);
                    }
                }
            }

            return totalRevenue;
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BillingList_Load(object sender, EventArgs e)
        {
            LoadBillingData();  
        }
    }
}
