namespace ATBM
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Trang chính";
            this.ClientSize = new System.Drawing.Size(500, 400);

            Button btnQuanLyUser = new Button() { Text = "Quản lý User", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 20) };
            btnQuanLyUser.Click += new System.EventHandler(this.btnQuanLyUser_Click);

            Button btnQuanLyQuyen = new Button() { Text = "Quản lý Quyền", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 70) };
            btnQuanLyQuyen.Click += new System.EventHandler(this.btnQuanLyQuyen_Click);

            Button btnQuanLyNhanVien = new Button() { Text = "Quản lý Nhân viên", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 120) };
            btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);

            Button btnQuanLySinhVien = new Button() { Text = "Quản lý Sinh viên", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 170) };
            btnQuanLySinhVien.Click += new System.EventHandler(this.btnQuanLySinhVien_Click);

            Button btnQuanLyMoMon = new Button() { Text = "Quản lý Mở môn", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 220) };
            btnQuanLyMoMon.Click += new System.EventHandler(this.btnQuanLyMoMon_Click);

            Button btnQuanLyDangKyHocPhan = new Button() { Text = "Quản lý ĐK học phần", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 270) };
            btnQuanLyDangKyHocPhan.Click += new System.EventHandler(this.btnQuanLyDangKyHocPhan_Click);

            Button btnGuiThongBao = new Button() { Text = "Gửi Thông báo", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 320) };
            btnGuiThongBao.Click += new System.EventHandler(this.btnGuiThongBao_Click);

            Button btnNhanThongBao = new Button() { Text = "Nhận Thông báo", Width = 200, Height = 40, Location = new System.Drawing.Point(150, 370) };
            btnNhanThongBao.Click += new System.EventHandler(this.btnNhanThongBao_Click);

            this.Controls.AddRange(new Control[] {
                btnQuanLyUser, btnQuanLyQuyen, btnQuanLyNhanVien, btnQuanLySinhVien,
                btnQuanLyMoMon, btnQuanLyDangKyHocPhan, btnGuiThongBao, btnNhanThongBao
            });
        }
    }
}
