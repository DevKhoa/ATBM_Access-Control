namespace ATBM
{
    partial class QLMM
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvMoMon;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.GroupBox groupBoxThongTin;

        private System.Windows.Forms.TextBox txtMaMoMon, txtTenHP, txtSoTC, txtSoTietLT, txtSoTietTH, txtNamHoc;
        private System.Windows.Forms.ComboBox cbMaHP, cbGiangVien, cbHocKy;
        private System.Windows.Forms.Button btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Quản lý mở môn";
            this.ClientSize = new System.Drawing.Size(700, 600);

            // GroupBox Danh sách mở môn
            groupBoxDanhSach = new GroupBox();
            groupBoxDanhSach.Text = "Danh sách môn học được mở";
            groupBoxDanhSach.SetBounds(20, 30, 650, 180);

            dgvMoMon = new DataGridView();
            dgvMoMon.Dock = DockStyle.Fill;
            dgvMoMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMoMon.Columns.Add("MaMoMon", "Mã mở môn");
            dgvMoMon.Columns.Add("MaHP", "Mã học phần");
            dgvMoMon.Columns.Add("TenHP", "Tên học phần");
            dgvMoMon.Columns.Add("GiangVien", "Giảng viên");
            dgvMoMon.Columns.Add("SoTC", "Số tín chỉ");
            dgvMoMon.Columns.Add("SoTietLT", "Số tiết lý thuyết");
            dgvMoMon.Columns.Add("SoTietTH", "Số tiết thực hành");
            dgvMoMon.Columns.Add("HocKy", "Học kỳ");
            dgvMoMon.Columns.Add("NamHoc", "Năm học");

            groupBoxDanhSach.Controls.Add(dgvMoMon);

            // GroupBox Thông tin môn mở
            groupBoxThongTin = new GroupBox();
            groupBoxThongTin.Text = "Thông tin môn học được mở";
            groupBoxThongTin.SetBounds(20, 220, 650, 300);

            // Các controls thông tin môn
            txtMaMoMon = new TextBox { Location = new System.Drawing.Point(30, 45), Width = 200 };
            cbMaHP = new ComboBox { Location = new System.Drawing.Point(30, 100), Width = 200 };
            txtTenHP = new TextBox { Location = new System.Drawing.Point(30, 155), Width = 200 };
            cbGiangVien = new ComboBox { Location = new System.Drawing.Point(30, 210), Width = 200 };

            txtSoTC = new TextBox { Location = new System.Drawing.Point(340, 45), Width = 200 };
            txtSoTietLT = new TextBox { Location = new System.Drawing.Point(340, 100), Width = 200 };
            txtSoTietTH = new TextBox { Location = new System.Drawing.Point(340, 155), Width = 200 };
            cbHocKy = new ComboBox { Location = new System.Drawing.Point(340, 210), Width = 200 };
            txtNamHoc = new TextBox { Location = new System.Drawing.Point(340, 260), Width = 200 };

            cbHocKy.Items.AddRange(new string[] { "1", "2", "3" });

            // Thêm các label và textbox vào groupBox
            groupBoxThongTin.Controls.AddRange(new Control[] {
                new Label { Text = "Mã mở môn", Location = new System.Drawing.Point(30, 25) },
                txtMaMoMon,
                new Label { Text = "Mã học phần", Location = new System.Drawing.Point(30, 75) },
                cbMaHP,
                new Label { Text = "Tên học phần", Location = new System.Drawing.Point(30, 130) },
                txtTenHP,
                new Label { Text = "Giảng viên", Location = new System.Drawing.Point(30, 185) },
                cbGiangVien,

                new Label { Text = "Số tín chỉ", Location = new System.Drawing.Point(340, 25) },
                txtSoTC,
                new Label { Text = "Số tiết lý thuyết", Location = new System.Drawing.Point(340, 75) },
                txtSoTietLT,
                new Label { Text = "Số tiết thực hành", Location = new System.Drawing.Point(340, 130) },
                txtSoTietTH,
                new Label { Text = "Học kỳ", Location = new System.Drawing.Point(340, 185) },
                cbHocKy,
                new Label { Text = "Năm học", Location = new System.Drawing.Point(340, 240) },
                txtNamHoc
            });

            // Buttons
            btnThem = new Button { Text = "Thêm", Location = new System.Drawing.Point(40, 530), Size = new System.Drawing.Size(80, 40) };
            btnXoa = new Button { Text = "Xóa", Location = new System.Drawing.Point(150, 530), Size = new System.Drawing.Size(80, 40) };
            btnLuu = new Button { Text = "Lưu", Location = new System.Drawing.Point(260, 530), Size = new System.Drawing.Size(80, 40) };
            btnTimKiem = new Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(370, 530), Size = new System.Drawing.Size(80, 40) };
            btnQuayLai = new Button { Text = "Quay lại", Location = new System.Drawing.Point(480, 530), Size = new System.Drawing.Size(80, 40) };

            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            // Thêm vào form
            this.Controls.AddRange(new Control[] {
                groupBoxDanhSach,
                groupBoxThongTin,
                btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai
            });
        }
    }
}
