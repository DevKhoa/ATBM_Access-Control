namespace ATBM
{
    partial class GuiTB
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.GroupBox groupBoxThongTin;

        private System.Windows.Forms.TextBox txtMaTP, txtNguoiTao, txtNoiDung;
        private System.Windows.Forms.ComboBox cbCapBac, cbLinhVuc, cbCoSo, cbTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;

        private System.Windows.Forms.Button btnThem, btnXoa, btnTimKiem, btnGui;
        private System.Windows.Forms.Button btnQuayLai;

        private void InitializeComponent()
        {
            this.Text = "Gửi thông báo";
            this.ClientSize = new System.Drawing.Size(750, 600);

            // GroupBox Danh sách thông báo
            groupBoxDanhSach = new GroupBox();
            groupBoxDanhSach.Text = "Danh sách thông báo";
            groupBoxDanhSach.SetBounds(20, 40, 700, 180);

            dgvThongBao = new DataGridView();
            dgvThongBao.Dock = DockStyle.Fill;
            dgvThongBao.ColumnCount = 7;
            dgvThongBao.Columns[0].Name = "Mã TP";
            dgvThongBao.Columns[1].Name = "Người tạo";
            dgvThongBao.Columns[2].Name = "Cấp bậc";
            dgvThongBao.Columns[3].Name = "Lĩnh vực";
            dgvThongBao.Columns[4].Name = "Cơ sở";
            dgvThongBao.Columns[5].Name = "Ngày tạo";
            dgvThongBao.Columns[6].Name = "Trạng thái";

            groupBoxDanhSach.Controls.Add(dgvThongBao);

            // GroupBox Thông tin thông báo
            groupBoxThongTin = new GroupBox();
            groupBoxThongTin.Text = "Thông tin thông báo";
            groupBoxThongTin.SetBounds(20, 230, 700, 250);

            // Controls
            txtMaTP = new TextBox { Location = new System.Drawing.Point(135, 30), Width = 200 };
            txtNguoiTao = new TextBox { Location = new System.Drawing.Point(135, 70), Width = 200 };
            cbCapBac = new ComboBox { Location = new System.Drawing.Point(135, 110), Width = 200 };
            cbLinhVuc = new ComboBox { Location = new System.Drawing.Point(135, 150), Width = 200 };

            cbCoSo = new ComboBox { Location = new System.Drawing.Point(485, 30), Width = 200 };
            dtpNgayTao = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm",
                Location = new System.Drawing.Point(485, 70),
                Width = 200,
                ShowUpDown = true
            };
            cbTrangThai = new ComboBox { Location = new System.Drawing.Point(485, 110), Width = 200 };
            txtNoiDung = new TextBox
            {
                Location = new System.Drawing.Point(485, 150),
                Width = 200,
                Height = 60,
                Multiline = true
            };

            // Labels
            groupBoxThongTin.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã TP", Location = new System.Drawing.Point(30, 30) },
                txtMaTP,
                new Label { Text = "Người tạo", Location = new System.Drawing.Point(30, 70) },
                txtNguoiTao,
                new Label { Text = "Cấp bậc", Location = new System.Drawing.Point(30, 110) },
                cbCapBac,
                new Label { Text = "Lĩnh vực", Location = new System.Drawing.Point(30, 150) },
                cbLinhVuc,

                new Label { Text = "Cơ sở", Location = new System.Drawing.Point(370, 30) },
                cbCoSo,
                new Label { Text = "Ngày tạo", Location = new System.Drawing.Point(370, 70) },
                dtpNgayTao,
                new Label { Text = "Trạng thái", Location = new System.Drawing.Point(370, 110) },
                cbTrangThai,
                new Label { Text = "Nội dung", Location = new System.Drawing.Point(370, 150) },
                txtNoiDung
            });

            // Buttons
            btnThem = new Button { Text = "Thêm", Location = new System.Drawing.Point(40, 500), Size = new System.Drawing.Size(80, 35) };
            btnXoa = new Button { Text = "Xóa", Location = new System.Drawing.Point(140, 500), Size = new System.Drawing.Size(80, 35) };
            btnTimKiem = new Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(240, 500), Size = new System.Drawing.Size(80, 35) };
            btnGui = new Button { Text = "Gửi", Location = new System.Drawing.Point(340, 500), Size = new System.Drawing.Size(80, 35) };
            btnQuayLai = new Button { Text = "Quay lại", Location = new System.Drawing.Point(440, 500), Size = new System.Drawing.Size(80, 35) };

            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnGui.Click += new System.EventHandler(this.btnGui_Click);
            btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);


            // Add to Form
            this.Controls.AddRange(new Control[]
            {
                groupBoxDanhSach,
                groupBoxThongTin,
                btnThem, btnXoa, btnTimKiem, btnGui, btnQuayLai,
            });
        }
    }
}
