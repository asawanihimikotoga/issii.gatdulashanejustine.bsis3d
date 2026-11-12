
namespace Activity3Finals
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            panel8 = new Panel();
            dgvProducts = new DataGridView();
            label19 = new Label();
            txtSearch = new TextBox();
            label18 = new Label();
            btnRefresh = new Button();
            panel7 = new Panel();
            cmbCategory = new ComboBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtReorder = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            txtProductName = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            lblOutOfStockCount = new Label();
            label7 = new Label();
            panel5 = new Panel();
            lblLowStockCount = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblInStockCount = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblTotalCount = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(141, 15);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 1;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BackgroundImage = Properties.Resources.himiko_toga_aesthetic_v2mauza8y78vf0z2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 609);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Controls.Add(dgvProducts);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(txtSearch);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(btnRefresh);
            panel8.Location = new Point(26, 423);
            panel8.Name = "panel8";
            panel8.Size = new Size(1063, 186);
            panel8.TabIndex = 16;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToOrderColumns = true;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(9, 49);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(1040, 150);
            dgvProducts.TabIndex = 20;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label19.Location = new Point(730, 12);
            label19.Name = "label19";
            label19.Size = new Size(71, 25);
            label19.TabIndex = 19;
            label19.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(807, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 23);
            txtSearch.TabIndex = 18;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label18.Location = new Point(11, 13);
            label18.Name = "label18";
            label18.Size = new Size(144, 25);
            label18.TabIndex = 2;
            label18.Text = "PRODUCT LIST";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.RosyBrown;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(157, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 31);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.Controls.Add(cmbCategory);
            panel7.Controls.Add(btnClear);
            panel7.Controls.Add(btnUpdate);
            panel7.Controls.Add(btnDelete);
            panel7.Controls.Add(btnAdd);
            panel7.Controls.Add(txtReorder);
            panel7.Controls.Add(txtPrice);
            panel7.Controls.Add(txtQuantity);
            panel7.Controls.Add(txtDescription);
            panel7.Controls.Add(txtProductName);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(26, 268);
            panel7.Name = "panel7";
            panel7.Size = new Size(1063, 139);
            panel7.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Computer Accessories", "", "Computer Hardware", "", "Computer Peripherals", "", "Networking Equipment", "", "Storage Devices", "", "Office Supplies", "", "Electronic Equipment", "", "Cable and Connectors", "", "Audio Equipment", "", "Other" });
            cmbCategory.Location = new Point(259, 35);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(198, 23);
            cmbCategory.TabIndex = 16;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RosyBrown;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClear.Location = new Point(936, 73);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 43);
            btnClear.TabIndex = 15;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(785, 73);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 43);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(936, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 43);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.Location = new Point(785, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 43);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD PRODUCT";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtReorder
            // 
            txtReorder.Location = new Point(505, 93);
            txtReorder.Name = "txtReorder";
            txtReorder.Size = new Size(198, 23);
            txtReorder.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(505, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(198, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(259, 93);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(198, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(32, 93);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(198, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(32, 35);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(198, 23);
            txtProductName.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label17.Location = new Point(505, 73);
            label17.Name = "label17";
            label17.Size = new Size(107, 17);
            label17.TabIndex = 17;
            label17.Text = "REORDER LEVEL";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label16.Location = new Point(505, 15);
            label16.Name = "label16";
            label16.Size = new Size(78, 17);
            label16.TabIndex = 18;
            label16.Text = "UNIT PRICE";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label15.Location = new Point(259, 15);
            label15.Name = "label15";
            label15.Size = new Size(74, 17);
            label15.TabIndex = 19;
            label15.Text = "CATEGORY";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label14.Location = new Point(259, 73);
            label14.Name = "label14";
            label14.Size = new Size(74, 17);
            label14.TabIndex = 20;
            label14.Text = "QUANTITY";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.Location = new Point(32, 73);
            label13.Name = "label13";
            label13.Size = new Size(92, 17);
            label13.TabIndex = 21;
            label13.Text = "DESCRIPTION";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(32, 15);
            label12.Name = "label12";
            label12.Size = new Size(111, 17);
            label12.TabIndex = 22;
            label12.Text = "PRODUCT NAME";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCoral;
            panel6.Controls.Add(lblOutOfStockCount);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(889, 163);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 90);
            panel6.TabIndex = 5;
            // 
            // lblOutOfStockCount
            // 
            lblOutOfStockCount.AutoSize = true;
            lblOutOfStockCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblOutOfStockCount.Location = new Point(86, 45);
            lblOutOfStockCount.Name = "lblOutOfStockCount";
            lblOutOfStockCount.Size = new Size(28, 32);
            lblOutOfStockCount.TabIndex = 0;
            lblOutOfStockCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(45, 21);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 1;
            label7.Text = "OUT OF STOCK";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSalmon;
            panel5.Controls.Add(lblLowStockCount);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(598, 163);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 90);
            panel5.TabIndex = 5;
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLowStockCount.Location = new Point(86, 45);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(28, 32);
            lblLowStockCount.TabIndex = 0;
            lblLowStockCount.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(55, 21);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 1;
            label6.Text = "LOW STOCK";
            label6.Click += label6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Chartreuse;
            panel4.Controls.Add(lblInStockCount);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(305, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 90);
            panel4.TabIndex = 5;
            // 
            // lblInStockCount
            // 
            lblInStockCount.AutoSize = true;
            lblInStockCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInStockCount.Location = new Point(86, 45);
            lblInStockCount.Name = "lblInStockCount";
            lblInStockCount.Size = new Size(28, 32);
            lblInStockCount.TabIndex = 0;
            lblInStockCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(64, 21);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 1;
            label5.Text = "IN STOCK";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTotalCount);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(26, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 90);
            panel3.TabIndex = 4;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCount.Location = new Point(86, 45);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(28, 32);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(32, 21);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 1;
            label4.Text = "TOTAL PRODUCTS";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(26, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 100);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(11, 50);
            label3.Name = "label3";
            label3.Size = new Size(308, 25);
            label3.TabIndex = 0;
            label3.Text = "Manage your inventory products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(347, 37);
            label2.TabIndex = 1;
            label2.Text = "PRODUCT MANAGEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 17;
            label1.Text = "WELCOME!";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 606);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;

        private Label lblTotalCount;
        private Label lblInStockCount;
        private Label lblLowStockCount;
        private Label lblOutOfStockCount;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnRefresh;

        private TextBox txtProductName;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtReorder;
        private TextBox txtSearch;

        private ComboBox cmbCategory;
        private DataGridView dgvProducts;
    }
}
