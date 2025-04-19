using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QLDKHP : Form
    {
        public QLDKHP()
        {
            InitializeComponent();
        }

        // Thêm các sự kiện xử lý cho các nút ở đây
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xử lý thêm học phần
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xử lý xóa học phần
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xử lý lưu học phần
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm học phần
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }
    }
}
