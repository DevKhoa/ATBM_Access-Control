using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                string connectionString = @"Data Source=localhost:1521/22127197_470_247;Persist Security Info=True;USER ID=" + username + ";PASSWORD=" + password + ";";
                OracleConnection con = new OracleConnection(connectionString);
                con.Open();
                MessageBox.Show("Kết nối thành công!");

                HomePage f = new HomePage();
                f.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công!\n" + "\nLỗi chi tiết: " + ex.Message);
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
