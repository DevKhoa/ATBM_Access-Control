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
            groupBoxDanhSach = new GroupBox();
            dgvThongBao = new DataGridView();
            groupBoxThongTin = new GroupBox();
            txtMaTP = new TextBox();
            txtNguoiTao = new TextBox();
            cbCapBac = new ComboBox();
            cbLinhVuc = new ComboBox();
            cbCoSo = new ComboBox();
            dtpNgayTao = new DateTimePicker();
            cbTrangThai = new ComboBox();
            txtNoiDung = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnGui = new Button();
            btnQuayLai = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongBao).BeginInit();
            groupBoxThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            groupBoxDanhSach.Controls.Add(dgvThongBao);
            groupBoxDanhSach.Location = new Point(20, 40);
            groupBoxDanhSach.Name = "groupBoxDanhSach";
            groupBoxDanhSach.Size = new Size(700, 180);
            groupBoxDanhSach.TabIndex = 0;
            groupBoxDanhSach.TabStop = false;
            groupBoxDanhSach.Text = "Danh sách thông báo";
            // 
            // dgvThongBao
            // 
            dgvThongBao.ColumnHeadersHeight = 29;
            dgvThongBao.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvThongBao.Dock = DockStyle.Fill;
            dgvThongBao.Location = new Point(3, 23);
            dgvThongBao.Name = "dgvThongBao";
            dgvThongBao.RowHeadersWidth = 51;
            dgvThongBao.Size = new Size(694, 154);
            dgvThongBao.TabIndex = 0;
            // 
            // groupBoxThongTin
            // 
            groupBoxThongTin.Controls.Add(txtMaTP);
            groupBoxThongTin.Controls.Add(txtNguoiTao);
            groupBoxThongTin.Controls.Add(cbCapBac);
            groupBoxThongTin.Controls.Add(cbLinhVuc);
            groupBoxThongTin.Controls.Add(cbCoSo);
            groupBoxThongTin.Controls.Add(dtpNgayTao);
            groupBoxThongTin.Controls.Add(cbTrangThai);
            groupBoxThongTin.Controls.Add(txtNoiDung);
            groupBoxThongTin.Location = new Point(20, 230);
            groupBoxThongTin.Name = "groupBoxThongTin";
            groupBoxThongTin.Size = new Size(700, 250);
            groupBoxThongTin.TabIndex = 1;
            groupBoxThongTin.TabStop = false;
            groupBoxThongTin.Text = "Thông tin thông báo";
            // 
            // txtMaTP
            // 
            txtMaTP.Location = new Point(0, 0);
            txtMaTP.Name = "txtMaTP";
            txtMaTP.Size = new Size(100, 27);
            txtMaTP.TabIndex = 1;
            // 
            // txtNguoiTao
            // 
            txtNguoiTao.Location = new Point(0, 0);
            txtNguoiTao.Name = "txtNguoiTao";
            txtNguoiTao.Size = new Size(100, 27);
            txtNguoiTao.TabIndex = 3;
            // 
            // cbCapBac
            // 
            cbCapBac.Location = new Point(0, 0);
            cbCapBac.Name = "cbCapBac";
            cbCapBac.Size = new Size(121, 28);
            cbCapBac.TabIndex = 5;
            // 
            // cbLinhVuc
            // 
            cbLinhVuc.Location = new Point(0, 0);
            cbLinhVuc.Name = "cbLinhVuc";
            cbLinhVuc.Size = new Size(121, 28);
            cbLinhVuc.TabIndex = 7;
            // 
            // cbCoSo
            // 
            cbCoSo.Location = new Point(0, 0);
            cbCoSo.Name = "cbCoSo";
            cbCoSo.Size = new Size(121, 28);
            cbCoSo.TabIndex = 9;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(0, 0);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(200, 27);
            dtpNgayTao.TabIndex = 11;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Location = new Point(0, 0);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(121, 28);
            cbTrangThai.TabIndex = 13;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(0, 0);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(100, 27);
            txtNoiDung.TabIndex = 15;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 3;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(0, 0);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(0, 0);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(75, 23);
            btnGui.TabIndex = 5;
            btnGui.Click += btnGui_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(0, 0);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 6;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // GuiTB
            // 
            ClientSize = new Size(750, 600);
            Controls.Add(groupBoxDanhSach);
            Controls.Add(groupBoxThongTin);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnGui);
            Controls.Add(btnQuayLai);
            Name = "GuiTB";
            Text = "Gửi thông báo";
            groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongBao).EndInit();
            groupBoxThongTin.ResumeLayout(false);
            groupBoxThongTin.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
