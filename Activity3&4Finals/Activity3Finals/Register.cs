
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Activity3Finals
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            btnRegister.Click += btnRegister_Click;
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (fullName == "" || username == "" ||
                password == "" || confirmPassword == "")
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show(
                    "Password must be at least 8 characters long.",
                    "Error",
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

                    string checkQuery =
                        "SELECT COUNT(*) FROM Users WHERE Username = ?";

                    using (OleDbCommand checkCmd =
                        new OleDbCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@Username", username);

                        int count = Convert.ToInt32(
                            checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "Username already exists.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    string query = @"INSERT INTO Users
                        (Username, PasswordHash, FullName, UserRole, IsActive)
                        VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, con))
                    {
                        string passwordHash =
                            PasswordHelper.HashPassword(password);

                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@UserRole", "User");
                        cmd.Parameters.AddWithValue("@IsActive", true);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Registration successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            Login loginForm = new Login();
                            loginForm.Show();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Registration failed. Please try again.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void linkSignUp_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }
    }
}
