
namespace Activity3Finals
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            linkSignUp = new LinkLabel();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtFullname = new TextBox();
            label2 = new Label();
            label1 = new Label();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            panel1.BackgroundImage =
                global::Activity3Finals.Properties.Resources.himiko_toga_aesthetic_v2mauza8y78vf0z2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 614);
            panel1.TabIndex = 1;

            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(207, 106);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 6;
            label4.Text = "SYSTEM";

            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(112, 63);
            label3.Name = "label3";
            label3.Size = new Size(292, 30);
            label3.TabIndex = 5;
            label3.Text = "INVENTORY MANAGEMENT";

            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(145, 149);
            label5.Name = "label5";
            label5.Size = new Size(215, 30);
            label5.TabIndex = 7;
            label5.Text = "REGISTER ACCOUNT";

            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(txtConfirmPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(linkSignUp);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtFullname);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(59, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 321);
            panel2.TabIndex = 0;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "FULL NAME";

            txtFullname.Location = new Point(53, 29);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(292, 23);
            txtFullname.TabIndex = 1;

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(154, 65);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";

            txtUsername.Location = new Point(53, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(292, 23);
            txtUsername.TabIndex = 3;

            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(154, 120);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 4;
            label7.Text = "PASSWORD";

            txtPassword.Location = new Point(53, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(128, 176);
            label6.Name = "label6";
            label6.Size = new Size(134, 17);
            label6.TabIndex = 6;
            label6.Text = "RE-TYPE PASSWORD";

            txtConfirmPassword.Location = new Point(53, 196);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(292, 23);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.UseSystemPasswordChar = true;

            btnRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegister.Location = new Point(156, 241);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;

            linkSignUp.AutoSize = true;
            linkSignUp.Location = new Point(94, 280);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(204, 15);
            linkSignUp.TabIndex = 9;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Already have an account? Log in here";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 603);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;

        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private Button btnRegister;
        private LinkLabel linkSignUp;
    }
}
