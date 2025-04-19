namespace ATBM
{
    partial class NhanTB
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.GroupBox groupBoxChiTiet;
        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.TextBox txtMaThongBao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaThongBao;
        private System.Windows.Forms.Button btnQuayLai;


        private void InitializeComponent()
        {
            this.Text = "Nhận thông báo";
            this.ClientSize = new System.Drawing.Size(850, 650);

            // GroupBox: Danh sách thông báo
            groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            groupBoxDanhSach.Text = "Danh sách thông báo";
            groupBoxDanhSach.SetBounds(20, 40, 800, 200);

            dgvThongBao = new System.Windows.Forms.DataGridView();
            dgvThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvThongBao.ColumnCount = 7;
            dgvThongBao.Columns[0].Name = "Mã thông báo";
            dgvThongBao.Columns[1].Name = "Người tạo";
            dgvThongBao.Columns[2].Name = "Cấp bậc";
            dgvThongBao.Columns[3].Name = "Lĩnh vực";
            dgvThongBao.Columns[4].Name = "Cơ sở";
            dgvThongBao.Columns[5].Name = "Ngày tạo";
            dgvThongBao.Columns[6].Name = "Trạng thái";

            groupBoxDanhSach.Controls.Add(dgvThongBao);

            // TextBox + Button tìm kiếm
            lblMaThongBao = new System.Windows.Forms.Label();
            lblMaThongBao.Text = "Mã thông báo";
            lblMaThongBao.Location = new System.Drawing.Point(30, 260);
            lblMaThongBao.Size = new System.Drawing.Size(100, 25);

            txtMaThongBao = new System.Windows.Forms.TextBox();
            txtMaThongBao.Location = new System.Drawing.Point(130, 255);
            txtMaThongBao.Size = new System.Drawing.Size(150, 25);

            btnTimKiem = new System.Windows.Forms.Button();
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Location = new System.Drawing.Point(300, 252);
            btnTimKiem.Size = new System.Drawing.Size(90, 30);

            btnQuayLai = new System.Windows.Forms.Button();
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.Location = new System.Drawing.Point(420, 252);
            btnQuayLai.Size = new System.Drawing.Size(90, 30);

            
            btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);


            // GroupBox: Chi tiết thông báo
            groupBoxChiTiet = new System.Windows.Forms.GroupBox();
            groupBoxChiTiet.Text = "";
            groupBoxChiTiet.SetBounds(20, 300, 800, 300);

            dgvChiTiet = new System.Windows.Forms.DataGridView();
            dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvChiTiet.ColumnCount = 5;
            dgvChiTiet.Columns[0].Name = "Mã thông báo";
            dgvChiTiet.Columns[1].Name = "Người tạo";
            dgvChiTiet.Columns[2].Name = "Ngày tạo";
            dgvChiTiet.Columns[3].Name = "Trạng thái";
            dgvChiTiet.Columns[4].Name = "Nội dung";

            groupBoxChiTiet.Controls.Add(dgvChiTiet);

            // Add controls
            this.Controls.Add(groupBoxDanhSach);
            this.Controls.Add(lblMaThongBao);
            this.Controls.Add(txtMaThongBao);
            this.Controls.Add(btnTimKiem);
            this.Controls.Add(groupBoxChiTiet);
            this.Controls.Add(btnQuayLai);
        }
    }
}
