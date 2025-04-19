using System;
using System.Windows.Forms;

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
            HomePage f = new HomePage();
            f.Show();
            this.Hide();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
