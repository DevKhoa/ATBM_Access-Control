namespace ATBM
{
    partial class QLDKHP
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.DateTimePicker dtpLichLT, dtpLichTH;

        private System.Windows.Forms.TextBox txtMaHP, txtTenHP, txtSoTinChi;
        private System.Windows.Forms.ComboBox cbGVLT, cbGVTH, cbLopHP;
        private System.Windows.Forms.Button btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai;

        private void InitializeComponent()
        {
            this.Text = "Quản lý đăng ký học phần";
            this.ClientSize = new System.Drawing.Size(750, 600);

            // GroupBox Danh sách học phần
            groupBoxDanhSach = new GroupBox();
            groupBoxDanhSach.Text = "Danh sách học phần";
            groupBoxDanhSach.SetBounds(20, 40, 700, 180);

            dgvHocPhan = new DataGridView();
            dgvHocPhan.Dock = DockStyle.Fill;
            dgvHocPhan.ColumnCount = 8;
            dgvHocPhan.Columns[0].Name = "Mã HP";
            dgvHocPhan.Columns[1].Name = "Tên học phần";
            dgvHocPhan.Columns[2].Name = "Số tín chỉ";
            dgvHocPhan.Columns[3].Name = "Giảng viên LT";
            dgvHocPhan.Columns[4].Name = "Giảng viên TH";
            dgvHocPhan.Columns[5].Name = "Lớp HP";
            dgvHocPhan.Columns[6].Name = "Lịch LT";
            dgvHocPhan.Columns[7].Name = "Lịch TH";

            groupBoxDanhSach.Controls.Add(dgvHocPhan);

            // GroupBox Thông tin học phần
            groupBoxThongTin = new GroupBox();
            groupBoxThongTin.Text = "Thông tin học phần";
            groupBoxThongTin.SetBounds(20, 230, 700, 250);

            // Controls
            txtMaHP = new TextBox { Location = new System.Drawing.Point(135, 30), Width = 200 };
            txtTenHP = new TextBox { Location = new System.Drawing.Point(135, 70), Width = 200 };
            cbGVLT = new ComboBox { Location = new System.Drawing.Point(135, 110), Width = 200 };
            cbGVTH = new ComboBox { Location = new System.Drawing.Point(135, 150), Width = 200 };

            dtpLichLT = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                Location = new System.Drawing.Point(485, 30),
                Width = 200,
                ShowUpDown = true
            };

            dtpLichTH = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                Location = new System.Drawing.Point(485, 70),
                Width = 200,
                ShowUpDown = true
            };


            cbLopHP = new ComboBox { Location = new System.Drawing.Point(485, 110), Width = 200 };
            txtSoTinChi = new TextBox { Location = new System.Drawing.Point(485, 150), Width = 200 };

            // Labels
            groupBoxThongTin.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã HP", Location = new System.Drawing.Point(30, 30) },
                txtMaHP,
                new Label { Text = "Tên HP", Location = new System.Drawing.Point(30, 70) },
                txtTenHP,
                new Label { Text = "GVLT", Location = new System.Drawing.Point(30, 110) },
                cbGVLT,
                new Label { Text = "GVTH ", Location = new System.Drawing.Point(30, 150) },
                cbGVTH,

                new Label { Text = "Lịch LT", Location = new System.Drawing.Point(370, 30) },
                dtpLichLT,
                new Label { Text = "Lịch TH", Location = new System.Drawing.Point(370, 70) },
                dtpLichTH,
                new Label { Text = "Lớp HP", Location = new System.Drawing.Point(370, 110) },
                cbLopHP,
                new Label { Text = "Số tín chỉ :", Location = new System.Drawing.Point(370, 150) },
                txtSoTinChi
            });

            // Buttons
            btnThem = new Button { Text = "Thêm", Location = new System.Drawing.Point(40, 500), Size = new System.Drawing.Size(80, 35) };
            btnXoa = new Button { Text = "Xóa", Location = new System.Drawing.Point(140, 500), Size = new System.Drawing.Size(80, 35) };
            btnLuu = new Button { Text = "Lưu", Location = new System.Drawing.Point(240, 500), Size = new System.Drawing.Size(80, 35) };
            btnTimKiem = new Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(340, 500), Size = new System.Drawing.Size(80, 35) };
            btnQuayLai = new Button { Text = "Quay lại", Location = new System.Drawing.Point(440, 500), Size = new System.Drawing.Size(80, 35) };

            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            // Add to Form
            this.Controls.AddRange(new Control[]
            {
                groupBoxDanhSach,
                groupBoxThongTin,
                btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai
            });
        }
    }
}
