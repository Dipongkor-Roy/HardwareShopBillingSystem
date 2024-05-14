using System.Data.SqlClient;

namespace HardwareShopBillingSystem
{
    public partial class LogIn : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=HardwareSystemDB;Integrated Security=True";
        public LogIn()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {   
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string? userRole = null;
            if (AuthenticateUser(username, password, out userRole) && userRole != null)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                // Close the login form
                this.Hide();

                // Open the main form
              /*  Products productShow= new Products();
                productShow.ShowDialog();*/
             
                Dashboard dashboard = new Dashboard(userRole);
                dashboard.ShowDialog();
                
                // ShowDialog() blocks until MainForm is closed
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, out string? userRole)
        {
            userRole = ""; // Initialize user role

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Role FROM userTb WHERE UserName = @Username AND Password = @Password";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        userRole = result.ToString(); // Set user role if authentication succeeds
                        return true;
                    }
                    else
                    {
                        return false; // Authentication failed
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error authenticating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Authentication failed due to an exception
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

