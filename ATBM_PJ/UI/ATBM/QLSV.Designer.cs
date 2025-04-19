namespace ATBM
{
    partial class QLSV
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtMaSV, txtHoTen, txtDiaChi, txtSDT, txtTinhTrangHV;
        private System.Windows.Forms.ComboBox cbGioiTinh, cbKhoa;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.Text = "Quản lý sinh viên";
            this.ClientSize = new System.Drawing.Size(650, 600);

            // GroupBox Danh sách
            groupBoxDanhSach = new GroupBox();
            groupBoxDanhSach.Text = "Danh sách sinh viên";
            groupBoxDanhSach.SetBounds(20, 40, 600, 180);

            dgvSinhVien = new DataGridView();
            dgvSinhVien.Dock = DockStyle.Fill;
            dgvSinhVien.ColumnCount = 7;
            dgvSinhVien.Columns[0].Name = "Mã SV";
            dgvSinhVien.Columns[1].Name = "Họ tên";
            dgvSinhVien.Columns[2].Name = "Giới tính";
            dgvSinhVien.Columns[3].Name = "Ngày sinh";
            dgvSinhVien.Columns[4].Name = "Địa chỉ";
            dgvSinhVien.Columns[5].Name = "SDT";
            dgvSinhVien.Columns.Add("Khoa", "Khoa");
            dgvSinhVien.Columns.Add("Tình trạng HV", "Tình trạng HV");

            groupBoxDanhSach.Controls.Add(dgvSinhVien);

            // GroupBox Thông tin
            groupBoxThongTin = new GroupBox();
            groupBoxThongTin.Text = "Thông tin sinh viên";
            groupBoxThongTin.SetBounds(20, 230, 600, 230);

            // TextBoxes and others
            txtMaSV = new TextBox { Location = new System.Drawing.Point(30, 40), Width = 200 };
            txtHoTen = new TextBox { Location = new System.Drawing.Point(30, 90), Width = 200 };
            cbGioiTinh = new ComboBox { Location = new System.Drawing.Point(30, 140), Width = 200 };
            cbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            dtpNgaySinh = new DateTimePicker { Location = new System.Drawing.Point(30, 190), Width = 200 };

            txtDiaChi = new TextBox { Location = new System.Drawing.Point(320, 40), Width = 200 };
            txtSDT = new TextBox { Location = new System.Drawing.Point(320, 90), Width = 200 };
            cbKhoa = new ComboBox { Location = new System.Drawing.Point(320, 140), Width = 200 };
            txtTinhTrangHV = new TextBox { Location = new System.Drawing.Point(320, 190), Width = 200 };

            // Labels
            groupBoxThongTin.Controls.AddRange(new Control[] {
                new Label { Text = "Mã sinh viên", Location = new System.Drawing.Point(30, 20) },
                txtMaSV,
                new Label { Text = "Họ tên", Location = new System.Drawing.Point(30, 70) },
                txtHoTen,
                new Label { Text = "Giới tính", Location = new System.Drawing.Point(30, 120) },
                cbGioiTinh,
                new Label { Text = "Ngày sinh", Location = new System.Drawing.Point(30, 170) },
                dtpNgaySinh,

                new Label { Text = "Địa chỉ", Location = new System.Drawing.Point(320, 20) },
                txtDiaChi,
                new Label { Text = "Số điện thoại", Location = new System.Drawing.Point(320, 70) },
                txtSDT,
                new Label { Text = "Khoa", Location = new System.Drawing.Point(320, 120) },
                cbKhoa,
                new Label { Text = "Tình trạng học vụ", Location = new System.Drawing.Point(320, 170) },
                txtTinhTrangHV
            });

            // Buttons
            btnThem = new Button { Text = "Thêm", Location = new System.Drawing.Point(40, 480), Size = new System.Drawing.Size(80, 40) };
            btnXoa = new Button { Text = "Xóa", Location = new System.Drawing.Point(140, 480), Size = new System.Drawing.Size(80, 40) };
            btnLuu = new Button { Text = "Lưu", Location = new System.Drawing.Point(240, 480), Size = new System.Drawing.Size(80, 40) };
            btnTimKiem = new Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(340, 480), Size = new System.Drawing.Size(80, 40) };
            btnQuayLai = new Button { Text = "Quay lại", Location = new System.Drawing.Point(440, 480), Size = new System.Drawing.Size(80, 40) };

            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);


            this.Controls.AddRange(new Control[] {
                groupBoxDanhSach,
                groupBoxThongTin,
                btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai
            });
        }
    }
}
