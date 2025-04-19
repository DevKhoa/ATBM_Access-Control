namespace ATBM
{
    partial class DangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(135, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(75, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(107, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(75, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(75, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(75, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // DangNhap
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang đăng nhập";
            Load += DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
