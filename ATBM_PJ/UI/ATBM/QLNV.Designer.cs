namespace ATBM
{
    partial class QLNV
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private DataGridView dgvNhanVien;
        private TextBox txtMaNV, txtHoTen, txtLuong, txtPhuCap, txtDT, txtMaDV, txtVaiTro;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai;
        private GroupBox groupBoxDanhSach, groupBoxThongTin;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // GroupBox Danh sách
            groupBoxDanhSach = new GroupBox();
            groupBoxDanhSach.Text = "Danh sách nhân viên";
            groupBoxDanhSach.SetBounds(20, 40, 720, 180);

            dgvNhanVien = new DataGridView();
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.ColumnCount = 8;
            dgvNhanVien.Columns[0].Name = "Mã NV";
            dgvNhanVien.Columns[1].Name = "Họ tên";
            dgvNhanVien.Columns[2].Name = "Giới tính";
            dgvNhanVien.Columns[3].Name = "Ngày sinh";
            dgvNhanVien.Columns[4].Name = "Lương";
            dgvNhanVien.Columns[5].Name = "Phụ cấp";
            dgvNhanVien.Columns[6].Name = "ĐT";
            dgvNhanVien.Columns[7].Name = "Vai trò";
            dgvNhanVien.Columns.Add("Mã ĐV", "Mã ĐV");

            groupBoxDanhSach.Controls.Add(dgvNhanVien);

            // GroupBox Thông tin
            groupBoxThongTin = new GroupBox();
            groupBoxThongTin.Text = "Thông tin nhân viên";
            groupBoxThongTin.SetBounds(20, 230, 720,220);

            // TextBox, ComboBox, DateTimePicker
            txtMaNV = new TextBox { Location = new System.Drawing.Point(30, 40), Width = 150 };
            txtHoTen = new TextBox { Location = new System.Drawing.Point(30, 85), Width = 150 };
            cbGioiTinh = new ComboBox { Location = new System.Drawing.Point(30, 135), Width = 150 };
            cbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            dtpNgaySinh = new DateTimePicker { Location = new System.Drawing.Point(30, 190), Width = 150 };

            txtLuong = new TextBox { Location = new System.Drawing.Point(250, 40), Width = 150 };
            txtPhuCap = new TextBox { Location = new System.Drawing.Point(250, 85), Width = 150 };
            txtVaiTro = new TextBox { Location = new System.Drawing.Point(250, 135), Width = 150 };

            txtDT = new TextBox { Location = new System.Drawing.Point(470, 40), Width = 150 };
            txtMaDV = new TextBox { Location = new System.Drawing.Point(470, 85), Width = 150 };

            groupBoxThongTin.Controls.AddRange(new Control[] {
                new Label { Text = "Mã nhân viên", Location = new System.Drawing.Point(30, 20) },
                txtMaNV,
                new Label { Text = "Họ tên", Location = new System.Drawing.Point(30, 65) },
                txtHoTen,
                new Label { Text = "Giới tính", Location = new System.Drawing.Point(30, 110) },
                cbGioiTinh,
                new Label { Text = "Ngày sinh", Location = new System.Drawing.Point(30, 165) },
                dtpNgaySinh,

                new Label { Text = "Lương", Location = new System.Drawing.Point(250, 20) },
                txtLuong,
                new Label { Text = "Phụ cấp", Location = new System.Drawing.Point(250, 65) },
                txtPhuCap,
                new Label { Text = "Vai trò", Location = new System.Drawing.Point(250, 110) },
                txtVaiTro,

                new Label { Text = "ĐT", Location = new System.Drawing.Point(470, 20) },
                txtDT,
                new Label { Text = "Mã ĐV", Location = new System.Drawing.Point(470, 65) },
                txtMaDV
            });

            // Buttons
            btnThem = new Button { Text = "Thêm", Location = new System.Drawing.Point(80, 460), Size = new System.Drawing.Size(100, 40), };
            btnXoa = new Button { Text = "Xóa", Location = new System.Drawing.Point(200, 460), Size = new System.Drawing.Size(100, 40) };
            btnLuu = new Button { Text = "Lưu", Location = new System.Drawing.Point(320, 460), Size = new System.Drawing.Size(100, 40) };
            btnTimKiem = new Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(440, 460), Size = new System.Drawing.Size(100, 40) };
            btnQuayLai = new Button { Text = "Quay lại", Location = new System.Drawing.Point(560, 460), Size = new System.Drawing.Size(100, 40) };

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

            this.Text = "Quản lý nhân viên";
            this.ClientSize = new System.Drawing.Size(780, 500);
        }
    }
}
