using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class NhanTB : Form
    {
        public NhanTB()
        {
            InitializeComponent();
        }

        // Bạn có thể thêm xử lý button tại đây
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maTB = txtMaThongBao.Text.Trim();
            // TODO: Xử lý tìm kiếm và hiển thị dữ liệu chi tiết tương ứng
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

    }
}
