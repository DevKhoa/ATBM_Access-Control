using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            QuanLyQuyen f = new QuanLyQuyen();
            f.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }
    }
}
