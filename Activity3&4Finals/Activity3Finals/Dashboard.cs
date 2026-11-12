
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Activity3Finals
{
    public partial class Dashboard : Form
    {
        private int selectedProductId = 0;

        public Dashboard()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            txtSearch.TextChanged += txtSearch_TextChanged;
            dgvProducts.CellClick += dgvProducts_CellClick;

            LoadProducts();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT Quantity, ReorderLevel FROM Products";

                    int total = 0;
                    int inStock = 0;
                    int lowStock = 0;
                    int outOfStock = 0;

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            total++;

                            int quantity = reader["Quantity"] == DBNull.Value
                                ? 0 : Convert.ToInt32(reader["Quantity"]);

                            int reorder = reader["ReorderLevel"] == DBNull.Value
                                ? 0 : Convert.ToInt32(reader["ReorderLevel"]);

                            if (quantity == 0)
                            {
                                outOfStock++;
                            }
                            else if (quantity <= reorder)
                            {
                                lowStock++;
                            }
                            else
                            {
                                inStock++;
                            }
                        }
                    }

                    lblTotalCount.Text = total.ToString();
                    lblInStockCount.Text = inStock.ToString();
                    lblLowStockCount.Text = lowStock.ToString();
                    lblOutOfStockCount.Text = outOfStock.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Statistic error: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = "SELECT * FROM Products ORDER BY ProductID DESC";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvProducts.DataSource = dt;
                    }
                }

                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private bool ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product category.");
                cmbCategory.Focus();
                return false;
            }

            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid product price.");
                txtPrice.Focus();
                return false;
            }

            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return false;
            }

            int reorder;

            if (!int.TryParse(txtReorder.Text, out reorder) || reorder < 0)
            {
                MessageBox.Show("Please enter a valid reorder level.");
                txtReorder.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
                return;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"INSERT INTO Products
                    (ProductName, Category, Description, UnitPrice, Quantity, ReorderLevel, CreatedAt)
                    VALUES (?, ?, ?, ?, ?, ?, Now())";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtProductName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbCategory.SelectedItem.ToString();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtDescription.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(txtPrice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtQuantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtReorder.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully.");

                ClearField();
                LoadProducts();
                LoadDashboardStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product row to update.");
                return;
            }

            if (!ValidateProduct())
                return;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"UPDATE Products SET
                    ProductName = ?, Category = ?, Description = ?,
                    UnitPrice = ?, Quantity = ?, ReorderLevel = ?
                    WHERE ProductID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtProductName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = cmbCategory.SelectedItem.ToString();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtDescription.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(txtPrice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtQuantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtReorder.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductId;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully.");

                ClearField();
                LoadProducts();
                LoadDashboardStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection con = Database.GetConnection())
                    {
                        con.Open();

                        string query = "DELETE FROM Products WHERE ProductID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductId;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product deleted successfully.");

                    ClearField();
                    LoadProducts();
                    LoadDashboardStats();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);

                txtProductName.Text = Convert.ToString(row.Cells["ProductName"].Value);
                cmbCategory.SelectedItem = Convert.ToString(row.Cells["Category"].Value);
                txtDescription.Text = Convert.ToString(row.Cells["Description"].Value);
                txtPrice.Text = Convert.ToString(row.Cells["UnitPrice"].Value);
                txtQuantity.Text = Convert.ToString(row.Cells["Quantity"].Value);
                txtReorder.Text = Convert.ToString(row.Cells["ReorderLevel"].Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtReorder.Clear();

            selectedProductId = 0;

            dgvProducts.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProducts();
            LoadDashboardStats();
            ClearField();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"SELECT * FROM Products
                    WHERE ProductName LIKE ?
                    OR Category LIKE ?
                    OR Description LIKE ?
                    ORDER BY ProductID DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        string search = "%" + txtSearch.Text.Trim() + "%";

                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = search;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = search;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = search;

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvProducts.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
