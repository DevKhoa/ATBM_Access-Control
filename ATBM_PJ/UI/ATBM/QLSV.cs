using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        // Các sự kiện xử lý ở đây
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xử lý thêm sinh viên
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xử lý xóa sinh viên
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

        private void groupBoxThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}
