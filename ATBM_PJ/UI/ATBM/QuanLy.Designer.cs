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
            this.Text = "Quản lý User/Role";
            this.ClientSize = new System.Drawing.Size(800, 600);

            Label lblTenUser = new Label() { Text = "Tên User", Location = new System.Drawing.Point(30, 40) };
            TextBox txtTenUser = new TextBox() { Location = new System.Drawing.Point(130, 35), Width = 150 };

            Label lblMatKhau = new Label() { Text = "Mật khẩu", Location = new System.Drawing.Point(30, 80) };
            TextBox txtMatKhau = new TextBox() { Location = new System.Drawing.Point(130, 75), Width = 150 };

            Button btnTaoUser = new Button() { Text = "Tạo mới", Location = new System.Drawing.Point(30, 120) };
            Button btnXoaUser = new Button() { Text = "Xóa", Location = new System.Drawing.Point(120, 120) };

            Label lblTenRole = new Label() { Text = "Tên Role", Location = new System.Drawing.Point(30, 180) };
            TextBox txtTenRole = new TextBox() { Location = new System.Drawing.Point(130, 175), Width = 150 };

            Button btnTaoRole = new Button() { Text = "Tạo mới", Location = new System.Drawing.Point(30, 220) };
            Button btnXoaRole = new Button() { Text = "Xóa", Location = new System.Drawing.Point(120, 220) };

            ListBox lstUser = new ListBox() { Location = new System.Drawing.Point(30, 280), Size = new System.Drawing.Size(200, 150) };
            Button btnXemUser = new Button() { Text = "Xem", Location = new System.Drawing.Point(80, 440) };

            // Tương tự, tạo các control cho user cũ/mới, mật khẩu cũ/mới
            Label lblUserCu = new Label() { Text = "Tên User cũ", Location = new System.Drawing.Point(320, 40) };
            TextBox txtUserCu = new TextBox() { Location = new System.Drawing.Point(420, 35), Width = 150 };

            Label lblMKCu = new Label() { Text = "Mật khẩu cũ", Location = new System.Drawing.Point(320, 80) };
            TextBox txtMKCu = new TextBox() { Location = new System.Drawing.Point(420, 75), Width = 150 };

            Label lblUserMoi = new Label() { Text = "Tên User mới", Location = new System.Drawing.Point(320, 120) };
            TextBox txtUserMoi = new TextBox() { Location = new System.Drawing.Point(420, 115), Width = 150 };

            Label lblMKMoi = new Label() { Text = "Mật khẩu mới", Location = new System.Drawing.Point(320, 160) };
            TextBox txtMKMoi = new TextBox() { Location = new System.Drawing.Point(420, 155), Width = 150 };

            Button btnCapNhatUser = new Button() { Text = "Cập nhật", Location = new System.Drawing.Point(380, 200) };

            Label lblRoleCu = new Label() { Text = "Tên Role cũ", Location = new System.Drawing.Point(600, 40) };
            TextBox txtRoleCu = new TextBox() { Location = new System.Drawing.Point(700, 35), Width = 150 };

            Label lblRoleMoi = new Label() { Text = "Tên Role mới", Location = new System.Drawing.Point(600, 80) };
            TextBox txtRoleMoi = new TextBox() { Location = new System.Drawing.Point(700, 75), Width = 150 };

            Button btnCapNhatRole = new Button() { Text = "Cập nhật", Location = new System.Drawing.Point(650, 120) };

            ListBox lstRole = new ListBox() { Location = new System.Drawing.Point(600, 160), Size = new System.Drawing.Size(200, 150) };
            Button btnXemRole = new Button() { Text = "Xem", Location = new System.Drawing.Point(650, 320) };

            Button btnTiep = new Button() { Text = "Tiếp", Location = new System.Drawing.Point(650, 500) };
            btnTiep.Click += new System.EventHandler(this.btnTiep_Click);

            Button btnQuayLai = new Button() { Text = "Quay lại", Location = new System.Drawing.Point(30, 500), Size = new System.Drawing.Size(90, 35) };
            btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            btnTaoUser.Size = new System.Drawing.Size(90, 35);
            btnXoaUser.Size = new System.Drawing.Size(90, 35);
            btnTaoRole.Size = new System.Drawing.Size(90, 35);
            btnXoaRole.Size = new System.Drawing.Size(90, 35);
            btnCapNhatUser.Size = new System.Drawing.Size(90, 35);
            btnCapNhatRole.Size = new System.Drawing.Size(90, 35);
            btnXemUser.Size = new System.Drawing.Size(90, 35);
            btnXemRole.Size = new System.Drawing.Size(90, 35);
            btnTiep.Size = new System.Drawing.Size(90, 35);


            this.Controls.AddRange(new Control[] {
                lblTenUser, txtTenUser, lblMatKhau, txtMatKhau, btnTaoUser, btnXoaUser,
                lblTenRole, txtTenRole, btnTaoRole, btnXoaRole, lstUser, btnXemUser,
                lblUserCu, txtUserCu, lblMKCu, txtMKCu, lblUserMoi, txtUserMoi, lblMKMoi, txtMKMoi, btnCapNhatUser,
                lblRoleCu, txtRoleCu, lblRoleMoi, txtRoleMoi, btnCapNhatRole, lstRole, btnXemRole,
                btnTiep, btnQuayLai
            });
        }
    }
}
