namespace ATBM
{
    partial class QuanLy
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
            lblTenUser = new Label();
            txtTenUser = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnTaoUser = new Button();
            btnXoaUser = new Button();
            btnXemUser = new Button();
            lblUserCu = new Label();
            txtUserCu = new TextBox();
            lblMKMoi = new Label();
            txtMKMoi = new TextBox();
            btnCapNhatUser = new Button();
            lblTenRole = new Label();
            txtTenRole = new TextBox();
            btnTaoRole = new Button();
            btnXoaRole = new Button();
            btnXemRole = new Button();
            lblRoleCu = new Label();
            txtRoleCu = new TextBox();
            lblRoleMoi = new Label();
            txtRoleMoi = new TextBox();
            btnCapNhatRole = new Button();
            btnQuayLai = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTenUser
            // 
            lblTenUser.Location = new Point(30, 30);
            lblTenUser.Name = "lblTenUser";
            lblTenUser.Size = new Size(100, 23);
            lblTenUser.TabIndex = 0;
            lblTenUser.Text = "Tên User:";
            lblTenUser.Click += lblTenUser_Click;
            // 
            // txtTenUser
            // 
            txtTenUser.Location = new Point(136, 30);
            txtTenUser.Name = "txtTenUser";
            txtTenUser.Size = new Size(150, 27);
            txtTenUser.TabIndex = 1;
            txtTenUser.TextChanged += txtTenUser_TextChanged;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Location = new Point(30, 70);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(100, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            lblMatKhau.Click += lblMatKhau_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(135, 68);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(150, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // btnTaoUser
            // 
            btnTaoUser.Location = new Point(30, 110);
            btnTaoUser.Name = "btnTaoUser";
            btnTaoUser.Size = new Size(75, 29);
            btnTaoUser.TabIndex = 4;
            btnTaoUser.Text = "Tạo User";
            btnTaoUser.Click += btnTaoUser_Click;
            // 
            // btnXoaUser
            // 
            btnXoaUser.Location = new Point(125, 110);
            btnXoaUser.Name = "btnXoaUser";
            btnXoaUser.Size = new Size(103, 29);
            btnXoaUser.TabIndex = 5;
            btnXoaUser.Text = "Xóa User";
            btnXoaUser.Click += btnXoaUser_Click;
            // 
            // btnXemUser
            // 
            btnXemUser.Location = new Point(254, 110);
            btnXemUser.Name = "btnXemUser";
            btnXemUser.Size = new Size(91, 29);
            btnXemUser.TabIndex = 6;
            btnXemUser.Text = "Xem User";
            btnXemUser.Click += btnXemUser_Click;
            // 
            // lblUserCu
            // 
            lblUserCu.Location = new Point(30, 359);
            lblUserCu.Name = "lblUserCu";
            lblUserCu.Size = new Size(100, 23);
            lblUserCu.TabIndex = 8;
            lblUserCu.Text = "User cần đổi:";
            lblUserCu.Click += lblUserCu_Click;
            // 
            // txtUserCu
            // 
            txtUserCu.Location = new Point(136, 355);
            txtUserCu.Name = "txtUserCu";
            txtUserCu.Size = new Size(150, 27);
            txtUserCu.TabIndex = 9;
            txtUserCu.TextChanged += txtUserCu_TextChanged;
            // 
            // lblMKMoi
            // 
            lblMKMoi.Location = new Point(55, 405);
            lblMKMoi.Name = "lblMKMoi";
            lblMKMoi.Size = new Size(75, 23);
            lblMKMoi.TabIndex = 14;
            lblMKMoi.Text = "MK mới:";
            lblMKMoi.Click += lblMKMoi_Click;
            // 
            // txtMKMoi
            // 
            txtMKMoi.Location = new Point(137, 402);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(149, 27);
            txtMKMoi.TabIndex = 15;
            txtMKMoi.TextChanged += txtMKMoi_TextChanged;
            // 
            // btnCapNhatUser
            // 
            btnCapNhatUser.Location = new Point(135, 452);
            btnCapNhatUser.Name = "btnCapNhatUser";
            btnCapNhatUser.Size = new Size(147, 41);
            btnCapNhatUser.TabIndex = 16;
            btnCapNhatUser.Text = "Cập nhật User";
            btnCapNhatUser.Click += btnCapNhatUser_Click;
            // 
            // lblTenRole
            // 
            lblTenRole.Location = new Point(392, 29);
            lblTenRole.Name = "lblTenRole";
            lblTenRole.Size = new Size(84, 23);
            lblTenRole.TabIndex = 17;
            lblTenRole.Text = "Tên Role:";
            lblTenRole.Click += lblTenRole_Click;
            // 
            // txtTenRole
            // 
            txtTenRole.Location = new Point(482, 29);
            txtTenRole.Name = "txtTenRole";
            txtTenRole.Size = new Size(150, 27);
            txtTenRole.TabIndex = 18;
            txtTenRole.TextChanged += txtTenRole_TextChanged;
            // 
            // btnTaoRole
            // 
            btnTaoRole.Location = new Point(392, 107);
            btnTaoRole.Name = "btnTaoRole";
            btnTaoRole.Size = new Size(84, 34);
            btnTaoRole.TabIndex = 19;
            btnTaoRole.Text = "Tạo Role";
            btnTaoRole.Click += btnTaoRole_Click;
            // 
            // btnXoaRole
            // 
            btnXoaRole.Location = new Point(501, 105);
            btnXoaRole.Name = "btnXoaRole";
            btnXoaRole.Size = new Size(84, 34);
            btnXoaRole.TabIndex = 20;
            btnXoaRole.Text = "Xóa Role";
            btnXoaRole.Click += btnXoaRole_Click;
            // 
            // btnXemRole
            // 
            btnXemRole.Location = new Point(606, 105);
            btnXemRole.Name = "btnXemRole";
            btnXemRole.Size = new Size(95, 34);
            btnXemRole.TabIndex = 21;
            btnXemRole.Text = "Xem Role";
            btnXemRole.Click += btnXemRole_Click;
            // 
            // lblRoleCu
            // 
            lblRoleCu.Location = new Point(363, 355);
            lblRoleCu.Name = "lblRoleCu";
            lblRoleCu.Size = new Size(101, 23);
            lblRoleCu.TabIndex = 23;
            lblRoleCu.Text = "Role cần đổi:";
            lblRoleCu.Click += lblRoleCu_Click;
            // 
            // txtRoleCu
            // 
            txtRoleCu.Location = new Point(482, 351);
            txtRoleCu.Name = "txtRoleCu";
            txtRoleCu.Size = new Size(150, 27);
            txtRoleCu.TabIndex = 24;
            txtRoleCu.TextChanged += txtRoleCu_TextChanged;
            // 
            // lblRoleMoi
            // 
            lblRoleMoi.Location = new Point(392, 402);
            lblRoleMoi.Name = "lblRoleMoi";
            lblRoleMoi.Size = new Size(72, 23);
            lblRoleMoi.TabIndex = 25;
            lblRoleMoi.Text = "MK mới:";
            lblRoleMoi.Click += lblRoleMoi_Click;
            // 
            // txtRoleMoi
            // 
            txtRoleMoi.Location = new Point(482, 398);
            txtRoleMoi.Name = "txtRoleMoi";
            txtRoleMoi.Size = new Size(150, 27);
            txtRoleMoi.TabIndex = 26;
            txtRoleMoi.TextChanged += txtRoleMoi_TextChanged;
            // 
            // btnCapNhatRole
            // 
            btnCapNhatRole.Location = new Point(482, 452);
            btnCapNhatRole.Name = "btnCapNhatRole";
            btnCapNhatRole.Size = new Size(150, 39);
            btnCapNhatRole.TabIndex = 27;
            btnCapNhatRole.Text = "Cập nhật Role";
            btnCapNhatRole.Click += btnCapNhatRole_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(30, 500);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 38);
            btnQuayLai.TabIndex = 29;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.Click += btnQuayLai_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(565, 189);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.Location = new Point(392, 68);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 31;
            label1.Text = "Mật khẩu:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(482, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 32;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(638, 66);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(153, 24);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Áp dụng mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // QuanLy
            // 
            ClientSize = new Size(800, 550);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lblTenUser);
            Controls.Add(txtTenUser);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(btnTaoUser);
            Controls.Add(btnXoaUser);
            Controls.Add(btnXemUser);
            Controls.Add(lblUserCu);
            Controls.Add(txtUserCu);
            Controls.Add(lblMKMoi);
            Controls.Add(txtMKMoi);
            Controls.Add(btnCapNhatUser);
            Controls.Add(lblTenRole);
            Controls.Add(txtTenRole);
            Controls.Add(btnTaoRole);
            Controls.Add(btnXoaRole);
            Controls.Add(btnXemRole);
            Controls.Add(lblRoleCu);
            Controls.Add(txtRoleCu);
            Controls.Add(lblRoleMoi);
            Controls.Add(txtRoleMoi);
            Controls.Add(btnCapNhatRole);
            Controls.Add(btnQuayLai);
            Name = "QuanLy";
            Text = "Quản lý User/Role";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTenUser;
        private TextBox txtTenUser;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Button btnTaoUser;
        private Button btnXoaUser;
        private Label lblTenRole;
        private TextBox txtTenRole;
        private Button btnTaoRole;
        private Button btnXoaRole;
        private Button btnXemUser;
        private Label lblUserCu;
        private TextBox txtUserCu;
        private Label lblMKMoi;
        private TextBox txtMKMoi;
        private Button btnCapNhatUser;
        private Label lblRoleCu;
        private TextBox txtRoleCu;
        private Label lblRoleMoi;
        private TextBox txtRoleMoi;
        private Button btnCapNhatRole;
        private Button btnXemRole;
        private Button btnQuayLai;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}
