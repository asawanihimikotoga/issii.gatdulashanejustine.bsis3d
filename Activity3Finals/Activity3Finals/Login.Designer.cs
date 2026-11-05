
namespace Activity3Finals
{
    partial class Login
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
            panel2 = new Panel();
            linkRegister = new LinkLabel();
            btnSignin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            panel1.BackgroundImage =
                global::Activity3Finals.Properties.Resources.himiko_toga_aesthetic_v2mauza8y78vf0z2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 614);
            panel1.TabIndex = 0;

            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(linkRegister);
            panel2.Controls.Add(btnSignin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(88, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 189);
            panel2.TabIndex = 0;

            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(97, 153);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(176, 15);
            linkRegister.TabIndex = 5;
            linkRegister.TabStop = true;
            linkRegister.Text = "Don't have an account? Register";

            btnSignin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSignin.Location = new Point(111, 113);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(150, 25);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "SIGN IN";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;

            txtPassword.Location = new Point(47, 75);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;

            txtUsername.Location = new Point(47, 29);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(307, 23);
            txtUsername.TabIndex = 2;

            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(135, 91);
            label3.Name = "label3";
            label3.Size = new Size(292, 30);
            label3.TabIndex = 6;
            label3.Text = "INVENTORY MANAGEMENT";

            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(230, 136);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 7;
            label4.Text = "SYSTEM";

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(151, 55);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 6;
            label5.Text = "PASSWORD";
            label5.Click += label5_Click;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 7;
            label1.Text = "USERNAME";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 612);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnSignin;
        private LinkLabel linkRegister;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
    }
}
