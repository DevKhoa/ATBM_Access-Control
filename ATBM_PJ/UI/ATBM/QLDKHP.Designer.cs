namespace ATBM
{
    partial class QLDKHP
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.DateTimePicker dtpLichLT, dtpLichTH;

        private System.Windows.Forms.TextBox txtMaHP, txtTenHP, txtSoTinChi, txtSoTLT, txtSoLTH;
        private System.Windows.Forms.ComboBox cbLopHP, cbDonVi;
        private System.Windows.Forms.Button btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai;

        private void InitializeComponent()
        {
            this.Text = "Quản lý đăng ký học phần";
            this.ClientSize = new System.Drawing.Size(800, 620);

            // GroupBox Danh sách học phần
            groupBoxDanhSach = new GroupBox();
            groupBoxDanhSach.Text = "Danh sách học phần";
            groupBoxDanhSach.SetBounds(20, 20, 760, 200);

            dgvHocPhan = new DataGridView();
            dgvHocPhan.Dock = DockStyle.Fill;
            dgvHocPhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHocPhan.Columns.Add("MaHP", "Mã học phần");
            dgvHocPhan.Columns.Add("TenHP", "Tên học phần");
            dgvHocPhan.Columns.Add("SoTC", "Số TC");
            dgvHocPhan.Columns.Add("SoTLT", "Số tiết LT");
            dgvHocPhan.Columns.Add("SoLTH", "Số tiết TH");
            dgvHocPhan.Columns.Add("MaDV", "Mã đơn vị");
            dgvHocPhan.Columns.Add("GiangVien", "Giảng viên");

            groupBoxDanhSach.Controls.Add(dgvHocPhan);

            // GroupBox Thông tin học phần
            groupBoxThongTin = new GroupBox();
            groupBoxThongTin.Text = "Thông tin học phần";
            groupBoxThongTin.SetBounds(20, 230, 760, 240);

            txtMaHP = new TextBox { Location = new System.Drawing.Point(140, 30), Width = 200 };
            txtTenHP = new TextBox { Location = new System.Drawing.Point(140, 70), Width = 200 };
            txtSoTinChi = new TextBox { Location = new System.Drawing.Point(140, 110), Width = 200 };
            txtSoTLT = new TextBox { Location = new System.Drawing.Point(140, 150), Width = 200 };
            txtSoLTH = new TextBox { Location = new System.Drawing.Point(140, 190), Width = 200 };

            cbDonVi = new ComboBox { Location = new System.Drawing.Point(500, 30), Width = 200 };

            groupBoxThongTin.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã HP", Location = new System.Drawing.Point(40, 30) }, txtMaHP,
                new Label { Text = "Tên HP", Location = new System.Drawing.Point(40, 70) }, txtTenHP,
                new Label { Text = "Số TC", Location = new System.Drawing.Point(40, 110) }, txtSoTinChi,
                new Label { Text = "Số TLT", Location = new System.Drawing.Point(40, 150) }, txtSoTLT,
                new Label { Text = "Số LTH", Location = new System.Drawing.Point(40, 190) }, txtSoLTH,
                new Label { Text = "Mã đơn vị", Location = new System.Drawing.Point(390, 30) },cbDonVi ,
            });

            // Buttons
            btnThem = new Button { Text = "Thêm", Location = new System.Drawing.Point(80, 500), Size = new System.Drawing.Size(80, 35) };
            btnXoa = new Button { Text = "Xóa", Location = new System.Drawing.Point(180, 500), Size = new System.Drawing.Size(80, 35) };
            btnLuu = new Button { Text = "Lưu", Location = new System.Drawing.Point(280, 500), Size = new System.Drawing.Size(80, 35) };
            btnTimKiem = new Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(380, 500), Size = new System.Drawing.Size(80, 35) };
            btnQuayLai = new Button { Text = "Quay lại", Location = new System.Drawing.Point(480, 500), Size = new System.Drawing.Size(80, 35) };

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
