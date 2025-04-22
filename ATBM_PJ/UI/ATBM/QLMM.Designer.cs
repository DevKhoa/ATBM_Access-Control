namespace ATBM
{
    partial class QLMM
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMoMon;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtMaMoMon, txtNamHoc, txtMaHP, txtGiangVien;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Button btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Quản lý mở môn";
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Load += new System.EventHandler(this.QLMM_Load);

            // GroupBox Danh sách
            groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            groupBoxDanhSach.Text = "Danh sách môn học được mở";
            groupBoxDanhSach.SetBounds(20, 30, 650, 180);

            dgvMoMon = new System.Windows.Forms.DataGridView();
            dgvMoMon.Name = "dgvMoMon";
            dgvMoMon.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMoMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMoMon.SelectionChanged += new System.EventHandler(this.dgvMoMon_SelectionChanged);
            groupBoxDanhSach.Controls.Add(dgvMoMon);

            // GroupBox Thông tin
            groupBoxThongTin = new System.Windows.Forms.GroupBox();
            groupBoxThongTin.Text = "Thông tin môn học được mở";
            groupBoxThongTin.SetBounds(20, 220, 650, 280);

            txtMaMoMon = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(140, 30), Width = 180 };
            txtMaHP = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(140, 70), Width = 180 };
            txtGiangVien = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(140, 110), Width = 180 };
            cbHocKy = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(460, 30), Width = 150 };
            txtNamHoc = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(460, 70), Width = 150 };
            cbHocKy.Items.AddRange(new object[] { "1", "2", "3" });

            groupBoxThongTin.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Mã mở môn", Location = new System.Drawing.Point(30, 30), AutoSize = true }, txtMaMoMon,
                new System.Windows.Forms.Label { Text = "Mã học phần", Location = new System.Drawing.Point(30, 70), AutoSize = true }, txtMaHP,
                new System.Windows.Forms.Label { Text = "Giảng viên", Location = new System.Drawing.Point(30, 110), AutoSize = true }, txtGiangVien,
                new System.Windows.Forms.Label { Text = "Học kỳ", Location = new System.Drawing.Point(370, 30), AutoSize = true }, cbHocKy,
                new System.Windows.Forms.Label { Text = "Năm học", Location = new System.Drawing.Point(370, 70), AutoSize = true }, txtNamHoc
            });

            btnThem = new System.Windows.Forms.Button { Text = "Thêm", Location = new System.Drawing.Point(40, 520), Size = new System.Drawing.Size(80, 40) };
            btnXoa = new System.Windows.Forms.Button { Text = "Xóa", Location = new System.Drawing.Point(150, 520), Size = new System.Drawing.Size(80, 40) };
            btnLuu = new System.Windows.Forms.Button { Text = "Lưu", Location = new System.Drawing.Point(260, 520), Size = new System.Drawing.Size(80, 40) };
            btnTimKiem = new System.Windows.Forms.Button { Text = "Tìm kiếm", Location = new System.Drawing.Point(370, 520), Size = new System.Drawing.Size(80, 40) };
            btnQuayLai = new System.Windows.Forms.Button { Text = "Quay lại", Location = new System.Drawing.Point(480, 520), Size = new System.Drawing.Size(80, 40) };

            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                groupBoxDanhSach, groupBoxThongTin,
                btnThem, btnXoa, btnLuu, btnTimKiem, btnQuayLai
            });
        }
    }
}
