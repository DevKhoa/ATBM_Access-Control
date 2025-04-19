using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnQuanLyUser_Click(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            f.Show();
            this.Hide();
        }

        private void btnQuanLyQuyen_Click(object sender, EventArgs e)
        {
            QuanLyQuyen f = new QuanLyQuyen();
            f.Show();
            this.Hide();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            QLNV f = new QLNV();
            f.Show();
            this.Hide();
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            QLSV f = new QLSV();
            f.Show();
            this.Hide();
        }

        private void btnQuanLyMoMon_Click(object sender, EventArgs e)
        {
            QLMM f = new QLMM();
            f.Show();
            this.Hide();
        }

        private void btnQuanLyDangKyHocPhan_Click(object sender, EventArgs e)
        {
            QLDKHP f = new QLDKHP();
            f.Show();
            this.Hide();
        }

        private void btnGuiThongBao_Click(object sender, EventArgs e)
        {
            GuiTB f = new GuiTB();
            f.Show();
            this.Hide();
        }

        private void btnNhanThongBao_Click(object sender, EventArgs e)
        {
            NhanTB f = new NhanTB();
            f.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
