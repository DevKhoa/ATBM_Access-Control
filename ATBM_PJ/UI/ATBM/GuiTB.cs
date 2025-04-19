using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class GuiTB : Form
    {
        public GuiTB()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xử lý thêm thông báo mới
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xử lý xóa thông báo
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm thông báo
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            // Xử lý gửi thông báo
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }
    }
}
