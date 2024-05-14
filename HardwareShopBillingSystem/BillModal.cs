using System;
using System.Windows.Forms;

namespace HardwareShopBillingSystem
{
    public partial class BillModal : Form
    {
        private DatabaseManager dbManager;
        private double totalBill;
        private string user;

        public BillModal(double totalBill, string user)
        {
            InitializeComponent();
            this.totalBill = totalBill;
            this.user = user;

            // Display total bill and user in labels
            BillbyLabel.Text = user;
            billLabel.Text = totalBill.ToString("C"); // Format as currency

            // Initialize DatabaseManager with connection string
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected date from DateTimePicker
                DateTime billingDate = DateTimePicker.Value;

                // Prepare field values for insertion
                var fieldValues = new Dictionary<string, object>
                {
                    { "BillBy", user },
                    { "Amount", totalBill },
                    { "BillingDate", billingDate }
                };
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
                DatabaseManager dbManager = new DatabaseManager(connectionString);


                // Insert new record into the billingTb table
                int rowsAffected = dbManager.InsertData("billingTb", fieldValues);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bill submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the current form (BillModal) and open the Billing form
                    this.Hide(); // Hide the current form (BillModal)

                    // Open the Billing form
                    Billing billingForm = new Billing();
                    billingForm.ShowDialog(); // Show Billing form as a modal dialog
                }
                else
                {
                    MessageBox.Show("Failed to submit bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting bill: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
