using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QLMM : Form
    {
        public QLMM()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xử lý thêm môn mở
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xử lý xóa môn mở
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xử lý lưu dữ liệu
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close(); 
        }
    }
}
