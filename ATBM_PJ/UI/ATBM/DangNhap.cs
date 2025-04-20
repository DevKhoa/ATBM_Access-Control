using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public static class SessionManager
    {
        public static string Username { get; set; } = string.Empty;
        public static string Password { get; set; } = string.Empty;
    }

    public static class OracleHelper
    {
        public static OracleConnection GetConnection()
        {
            string cs = $@"Data Source=localhost:1521/22127197_470_247;Persist Security Info=True;USER ID={SessionManager.Username};PASSWORD={SessionManager.Password};";
            return new OracleConnection(cs);
        }
    }
}

namespace ATBM
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                // Test kết nối
                string testCs = $@"Data Source=localhost:1521/22127197_470_247;Persist Security Info=True;USER ID={username};PASSWORD={password};";
                using (var con = new OracleConnection(testCs))
                {
                    con.Open();
                }

                // Lưu phiên làm việc
                SessionManager.Username = username;
                SessionManager.Password = password;

                MessageBox.Show("Kết nối thành công!");
                var home = new HomePage();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công!\nLỗi chi tiết: " + ex.Message);
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
        }
    }
}