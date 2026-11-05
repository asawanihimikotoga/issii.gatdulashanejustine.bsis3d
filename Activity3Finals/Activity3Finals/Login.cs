
using Microsoft.Win32;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Activity3Finals
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            linkRegister.LinkClicked += linkRegister_LinkClicked;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query =
                        "SELECT * FROM Users WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "Username not found.",
                                    "Login Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }

                            string storedHash =
                                reader["PasswordHash"].ToString();

                            string fullName =
                                reader["FullName"].ToString();

                            bool isActive =
                                Convert.ToBoolean(reader["IsActive"]);

                            if (!PasswordHelper.VerifyPassword(
                                password, storedHash))
                            {
                                MessageBox.Show(
                                    "Incorrect password.",
                                    "Login Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }

                            if (!isActive)
                            {
                                MessageBox.Show(
                                    "Your account is inactive. Please contact the administrator.",
                                    "Login Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }

                            MessageBox.Show(
                                $"Welcome, {fullName}!",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();

                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred: " + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void linkRegister_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
