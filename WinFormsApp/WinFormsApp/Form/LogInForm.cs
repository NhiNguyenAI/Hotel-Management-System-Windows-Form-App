using System;
using System.Data;
using System.Windows.Forms;
using HotelManagementSystemProject;
using Microsoft.Data.SqlClient; // Use the library to connect to SQL Server

namespace HotelManagementSystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        // Display tooltips on controls
        private void pictureBoxMinimizeWindows_Hover(object sender, EventArgs e)
        {
            toolTipLogInForm.SetToolTip(pictureBoxMinimizeWindows, "Minimize");
        }

        private void pictureBoxClose_Hover(object sender, EventArgs e)
        {
            toolTipLogInForm.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxShowPassword_Hover(object sender, EventArgs e)
        {
            toolTipLogInForm.SetToolTip(pictureBoxShowPassword, "Show Password");
        }

        private void pictureBoxHidePassword_Hover(object sender, EventArgs e)
        {
            toolTipLogInForm.SetToolTip(pictureBoxHidePassword, "Hide Password");
        }

        // Click events
        private void pictureBoxMinimizeWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxHidePassword_Click(object sender, EventArgs e)
        {
            pictureBoxHidePassword.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShowPassword.Show();
        }

        private void pictureBoxShowPassword_Click(object sender, EventArgs e)
        {
            pictureBoxShowPassword.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHidePassword.Show();
        }

        // Event triggered when clicking the login button
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // Database connection string
            string connectionString = "Server=localhost;Database=Hotel_Management;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to validate login
                    string query = "SELECT COUNT(*) FROM User_Table WHERE User_Name = @username AND User_Password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Bind parameters from TextBox inputs
                        command.Parameters.AddWithValue("@username", textBoxUserName.Text.Trim());
                        command.Parameters.AddWithValue("@password", textBoxPassword.Text.Trim());

                        // Execute the query and get the result
                        object result = command.ExecuteScalar();
                        if (result != null && (int)result > 0)
                        {
                            // Show the Dashboard Form if login is successful
                            FormDashboard fd = new FormDashboard();
                            fd.Show();
                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle connection errors or other exceptions
                    MessageBox.Show("Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
