namespace ATBM
{
    partial class QuanLyQuyen
    {

        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            label2 = new Label();
            label6 = new Label();
            txtTenDoiTuongThuHoi = new TextBox();
            txtTenCotTableThuHoi = new TextBox();
            panel4 = new Panel();
            cbDeleteThuHoi = new CheckBox();
            cbInsertThuHoi = new CheckBox();
            cbUpdateThuHoi = new CheckBox();
            cbSelectThuHoi = new CheckBox();
            label7 = new Label();
            lbThuHoi = new Label();
            label10 = new Label();
            txtThuHoi = new TextBox();
            btnCapRole = new Button();
            btnCapQuyen = new Button();
            label14 = new Label();
            label15 = new Label();
            txtTenDoiTuongCapQuyen = new TextBox();
            txtTenCotTableCapQuyen = new TextBox();
            panel3 = new Panel();
            cbGrantOptionCapQuyen = new CheckBox();
            cbDeleteCapQuyen = new CheckBox();
            cbInsertCapQuyen = new CheckBox();
            cbUpdateCapQuyen = new CheckBox();
            cbSelectCapQuyen = new CheckBox();
            label13 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            cbFunctCapQuyen = new CheckBox();
            cbViewCapQuyen = new CheckBox();
            cbProcCapQuyen = new CheckBox();
            cbTableCapQuyen = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            lbCapQuyen = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblTitle = new Label();
            txtCapQuyen = new TextBox();
            txtTenUser = new TextBox();
            lstQuyenUser = new ListBox();
            btnXemQuyenUser = new Button();
            txtTenRole = new TextBox();
            lstQuyenRole = new ListBox();
            btnXemQuyenRole = new Button();
            btnTiep = new Button();
            panel7 = new Panel();
            cbFunctThuHoi = new CheckBox();
            cbViewThuHoi = new CheckBox();
            cbProcThuHoi = new CheckBox();
            cbTableThuHoi = new CheckBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1068, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 97);
            panel1.TabIndex = 66;
            // 
            // button3
            // 
            button3.Location = new Point(848, 443);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 122;
            button3.Text = "Thu hồi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(799, 208);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 121;
            label2.Text = "Tên đối tượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(799, 264);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 120;
            label6.Text = "Tên cột Table (nếu có)";
            // 
            // txtTenDoiTuongThuHoi
            // 
            txtTenDoiTuongThuHoi.Location = new Point(791, 234);
            txtTenDoiTuongThuHoi.Name = "txtTenDoiTuongThuHoi";
            txtTenDoiTuongThuHoi.Size = new Size(174, 27);
            txtTenDoiTuongThuHoi.TabIndex = 118;
            txtTenDoiTuongThuHoi.TextChanged += txtTenDoiTuongThuHoi_TextChanged;
            // 
            // txtTenCotTableThuHoi
            // 
            txtTenCotTableThuHoi.Location = new Point(791, 287);
            txtTenCotTableThuHoi.Name = "txtTenCotTableThuHoi";
            txtTenCotTableThuHoi.Size = new Size(174, 27);
            txtTenCotTableThuHoi.TabIndex = 119;
            txtTenCotTableThuHoi.TextChanged += txtTenCotTableThuHoi_TextChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cbDeleteThuHoi);
            panel4.Controls.Add(cbInsertThuHoi);
            panel4.Controls.Add(cbUpdateThuHoi);
            panel4.Controls.Add(cbSelectThuHoi);
            panel4.Location = new Point(791, 359);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 78);
            panel4.TabIndex = 117;
            // 
            // cbDeleteThuHoi
            // 
            cbDeleteThuHoi.AutoSize = true;
            cbDeleteThuHoi.Location = new Point(121, 42);
            cbDeleteThuHoi.Name = "cbDeleteThuHoi";
            cbDeleteThuHoi.Size = new Size(75, 24);
            cbDeleteThuHoi.TabIndex = 3;
            cbDeleteThuHoi.Text = "Delete";
            cbDeleteThuHoi.UseVisualStyleBackColor = true;
            cbDeleteThuHoi.CheckedChanged += cbDeleteThuHoi_CheckedChanged;
            // 
            // cbInsertThuHoi
            // 
            cbInsertThuHoi.AutoSize = true;
            cbInsertThuHoi.Location = new Point(121, 3);
            cbInsertThuHoi.Name = "cbInsertThuHoi";
            cbInsertThuHoi.Size = new Size(67, 24);
            cbInsertThuHoi.TabIndex = 2;
            cbInsertThuHoi.Text = "Insert";
            cbInsertThuHoi.UseVisualStyleBackColor = true;
            cbInsertThuHoi.CheckedChanged += cbInsertThuHoi_CheckedChanged;
            // 
            // cbUpdateThuHoi
            // 
            cbUpdateThuHoi.AutoSize = true;
            cbUpdateThuHoi.Location = new Point(3, 42);
            cbUpdateThuHoi.Name = "cbUpdateThuHoi";
            cbUpdateThuHoi.Size = new Size(80, 24);
            cbUpdateThuHoi.TabIndex = 1;
            cbUpdateThuHoi.Text = "Update";
            cbUpdateThuHoi.UseVisualStyleBackColor = true;
            cbUpdateThuHoi.CheckedChanged += cbUpdateThuHoi_CheckedChanged;
            // 
            // cbSelectThuHoi
            // 
            cbSelectThuHoi.AutoSize = true;
            cbSelectThuHoi.Location = new Point(3, 3);
            cbSelectThuHoi.Name = "cbSelectThuHoi";
            cbSelectThuHoi.Size = new Size(71, 24);
            cbSelectThuHoi.TabIndex = 0;
            cbSelectThuHoi.Text = "Select";
            cbSelectThuHoi.UseVisualStyleBackColor = true;
            cbSelectThuHoi.CheckedChanged += cbSelectThuHoi_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(791, 329);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 116;
            label7.Text = "Quyền";
            // 
            // lbThuHoi
            // 
            lbThuHoi.AutoSize = true;
            lbThuHoi.Location = new Point(791, 56);
            lbThuHoi.Name = "lbThuHoi";
            lbThuHoi.Size = new Size(101, 20);
            lbThuHoi.TabIndex = 114;
            lbThuHoi.Text = "Tên User/Role";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(791, 109);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 113;
            label10.Text = "Loại đối tượng";
            // 
            // txtThuHoi
            // 
            txtThuHoi.Location = new Point(791, 79);
            txtThuHoi.Name = "txtThuHoi";
            txtThuHoi.Size = new Size(174, 27);
            txtThuHoi.TabIndex = 112;
            txtThuHoi.TextChanged += txtThuHoi_TextChanged;
            // 
            // btnCapRole
            // 
            btnCapRole.Location = new Point(457, 204);
            btnCapRole.Name = "btnCapRole";
            btnCapRole.Size = new Size(94, 29);
            btnCapRole.TabIndex = 111;
            btnCapRole.Text = "Cấp quyền";
            btnCapRole.UseVisualStyleBackColor = true;
            btnCapRole.Click += btnCapRole_Click;
            // 
            // btnCapQuyen
            // 
            btnCapQuyen.Location = new Point(91, 471);
            btnCapQuyen.Name = "btnCapQuyen";
            btnCapQuyen.Size = new Size(94, 29);
            btnCapQuyen.TabIndex = 110;
            btnCapQuyen.Text = "Cấp quyền";
            btnCapQuyen.UseVisualStyleBackColor = true;
            btnCapQuyen.Click += btnCapQuyen_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(41, 208);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 109;
            label14.Text = "Tên đối tượng";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(41, 264);
            label15.Name = "label15";
            label15.Size = new Size(154, 20);
            label15.TabIndex = 108;
            label15.Text = "Tên cột Table (nếu có)";
            // 
            // txtTenDoiTuongCapQuyen
            // 
            txtTenDoiTuongCapQuyen.Location = new Point(33, 234);
            txtTenDoiTuongCapQuyen.Name = "txtTenDoiTuongCapQuyen";
            txtTenDoiTuongCapQuyen.Size = new Size(174, 27);
            txtTenDoiTuongCapQuyen.TabIndex = 106;
            txtTenDoiTuongCapQuyen.TextChanged += txtTenDoiTuongCapQuyen_TextChanged;
            // 
            // txtTenCotTableCapQuyen
            // 
            txtTenCotTableCapQuyen.Location = new Point(33, 287);
            txtTenCotTableCapQuyen.Name = "txtTenCotTableCapQuyen";
            txtTenCotTableCapQuyen.Size = new Size(174, 27);
            txtTenCotTableCapQuyen.TabIndex = 107;
            txtTenCotTableCapQuyen.TextChanged += txtTenCotTableCapQuyen_TextChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cbGrantOptionCapQuyen);
            panel3.Controls.Add(cbDeleteCapQuyen);
            panel3.Controls.Add(cbInsertCapQuyen);
            panel3.Controls.Add(cbUpdateCapQuyen);
            panel3.Controls.Add(cbSelectCapQuyen);
            panel3.Location = new Point(33, 359);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 106);
            panel3.TabIndex = 105;
            // 
            // cbGrantOptionCapQuyen
            // 
            cbGrantOptionCapQuyen.AutoSize = true;
            cbGrantOptionCapQuyen.Location = new Point(3, 79);
            cbGrantOptionCapQuyen.Name = "cbGrantOptionCapQuyen";
            cbGrantOptionCapQuyen.Size = new Size(117, 24);
            cbGrantOptionCapQuyen.TabIndex = 4;
            cbGrantOptionCapQuyen.Text = "Grant Option";
            cbGrantOptionCapQuyen.UseVisualStyleBackColor = true;
            cbGrantOptionCapQuyen.CheckedChanged += cbGrantOptionCapQuyen_CheckedChanged;
            // 
            // cbDeleteCapQuyen
            // 
            cbDeleteCapQuyen.AutoSize = true;
            cbDeleteCapQuyen.Location = new Point(121, 42);
            cbDeleteCapQuyen.Name = "cbDeleteCapQuyen";
            cbDeleteCapQuyen.Size = new Size(75, 24);
            cbDeleteCapQuyen.TabIndex = 3;
            cbDeleteCapQuyen.Text = "Delete";
            cbDeleteCapQuyen.UseVisualStyleBackColor = true;
            cbDeleteCapQuyen.CheckedChanged += cbDeleteCapQuyen_CheckedChanged;
            // 
            // cbInsertCapQuyen
            // 
            cbInsertCapQuyen.AutoSize = true;
            cbInsertCapQuyen.Location = new Point(121, 3);
            cbInsertCapQuyen.Name = "cbInsertCapQuyen";
            cbInsertCapQuyen.Size = new Size(67, 24);
            cbInsertCapQuyen.TabIndex = 2;
            cbInsertCapQuyen.Text = "Insert";
            cbInsertCapQuyen.UseVisualStyleBackColor = true;
            cbInsertCapQuyen.CheckedChanged += cbInsertCapQuyen_CheckedChanged;
            // 
            // cbUpdateCapQuyen
            // 
            cbUpdateCapQuyen.AutoSize = true;
            cbUpdateCapQuyen.Location = new Point(3, 42);
            cbUpdateCapQuyen.Name = "cbUpdateCapQuyen";
            cbUpdateCapQuyen.Size = new Size(80, 24);
            cbUpdateCapQuyen.TabIndex = 1;
            cbUpdateCapQuyen.Text = "Update";
            cbUpdateCapQuyen.UseVisualStyleBackColor = true;
            cbUpdateCapQuyen.CheckedChanged += cbUpdateCapQuyen_CheckedChanged;
            // 
            // cbSelectCapQuyen
            // 
            cbSelectCapQuyen.AutoSize = true;
            cbSelectCapQuyen.Location = new Point(3, 3);
            cbSelectCapQuyen.Name = "cbSelectCapQuyen";
            cbSelectCapQuyen.Size = new Size(71, 24);
            cbSelectCapQuyen.TabIndex = 0;
            cbSelectCapQuyen.Text = "Select";
            cbSelectCapQuyen.UseVisualStyleBackColor = true;
            cbSelectCapQuyen.CheckedChanged += cbSelectCapQuyen_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 329);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 104;
            label13.Text = "Quyền";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(33, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 60);
            panel2.TabIndex = 103;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(cbFunctCapQuyen);
            panel6.Controls.Add(cbViewCapQuyen);
            panel6.Controls.Add(cbProcCapQuyen);
            panel6.Controls.Add(cbTableCapQuyen);
            panel6.Location = new Point(-1, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 60);
            panel6.TabIndex = 104;
            // 
            // cbFunctCapQuyen
            // 
            cbFunctCapQuyen.AutoSize = true;
            cbFunctCapQuyen.Location = new Point(121, 33);
            cbFunctCapQuyen.Name = "cbFunctCapQuyen";
            cbFunctCapQuyen.Size = new Size(66, 24);
            cbFunctCapQuyen.TabIndex = 3;
            cbFunctCapQuyen.Text = "Funct";
            cbFunctCapQuyen.UseVisualStyleBackColor = true;
            cbFunctCapQuyen.CheckedChanged += cbFunctCapQuyen_CheckedChanged;
            // 
            // cbViewCapQuyen
            // 
            cbViewCapQuyen.AutoSize = true;
            cbViewCapQuyen.Location = new Point(121, 3);
            cbViewCapQuyen.Name = "cbViewCapQuyen";
            cbViewCapQuyen.Size = new Size(63, 24);
            cbViewCapQuyen.TabIndex = 2;
            cbViewCapQuyen.Text = "View";
            cbViewCapQuyen.UseVisualStyleBackColor = true;
            cbViewCapQuyen.CheckedChanged += cbViewCapQuyen_CheckedChanged;
            // 
            // cbProcCapQuyen
            // 
            cbProcCapQuyen.AutoSize = true;
            cbProcCapQuyen.Location = new Point(3, 33);
            cbProcCapQuyen.Name = "cbProcCapQuyen";
            cbProcCapQuyen.Size = new Size(60, 24);
            cbProcCapQuyen.TabIndex = 1;
            cbProcCapQuyen.Text = "Proc";
            cbProcCapQuyen.UseVisualStyleBackColor = true;
            cbProcCapQuyen.CheckedChanged += cbProcCapQuyen_CheckedChanged;
            // 
            // cbTableCapQuyen
            // 
            cbTableCapQuyen.AutoSize = true;
            cbTableCapQuyen.Location = new Point(3, 3);
            cbTableCapQuyen.Name = "cbTableCapQuyen";
            cbTableCapQuyen.Size = new Size(66, 24);
            cbTableCapQuyen.TabIndex = 0;
            cbTableCapQuyen.Text = "Table";
            cbTableCapQuyen.UseVisualStyleBackColor = true;
            cbTableCapQuyen.CheckedChanged += cbTableCapQuyen_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(121, 33);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(66, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Funct";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(121, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "View";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 33);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(60, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Proc";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Table";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(440, 400);
            label12.Name = "label12";
            label12.Size = new Size(155, 20);
            label12.TabIndex = 102;
            label12.Text = "Danh sách quyền Role";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(441, 132);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 101;
            label11.Text = "Tên User";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 56);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 100;
            label9.Text = "Tên Role";
            // 
            // lbCapQuyen
            // 
            lbCapQuyen.AutoSize = true;
            lbCapQuyen.Location = new Point(33, 56);
            lbCapQuyen.Name = "lbCapQuyen";
            lbCapQuyen.Size = new Size(101, 20);
            lbCapQuyen.TabIndex = 99;
            lbCapQuyen.Text = "Tên User/Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 109);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 98;
            label4.Text = "Loại đối tượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 262);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 97;
            label3.Text = "Danh sách quyền User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 471);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 96;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(26, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 20);
            lblTitle.TabIndex = 87;
            lblTitle.Text = "Quản lý User/Role";
            // 
            // txtCapQuyen
            // 
            txtCapQuyen.Location = new Point(33, 79);
            txtCapQuyen.Name = "txtCapQuyen";
            txtCapQuyen.Size = new Size(174, 27);
            txtCapQuyen.TabIndex = 88;
            txtCapQuyen.TextChanged += txtTenUser_TextChanged;
            // 
            // txtTenUser
            // 
            txtTenUser.Location = new Point(431, 162);
            txtTenUser.Name = "txtTenUser";
            txtTenUser.Size = new Size(172, 27);
            txtTenUser.TabIndex = 89;
            txtTenUser.TextChanged += txtTenUser_TextChanged_1;
            // 
            // lstQuyenUser
            // 
            lstQuyenUser.Location = new Point(401, 285);
            lstQuyenUser.Name = "lstQuyenUser";
            lstQuyenUser.Size = new Size(230, 64);
            lstQuyenUser.TabIndex = 90;
            lstQuyenUser.SelectedIndexChanged += lstQuyenUser_SelectedIndexChanged;
            // 
            // btnXemQuyenUser
            // 
            btnXemQuyenUser.Location = new Point(463, 355);
            btnXemQuyenUser.Name = "btnXemQuyenUser";
            btnXemQuyenUser.Size = new Size(100, 38);
            btnXemQuyenUser.TabIndex = 91;
            btnXemQuyenUser.Text = "Xem";
            btnXemQuyenUser.Click += btnXemQuyenUser_Click;
            // 
            // txtTenRole
            // 
            txtTenRole.Location = new Point(431, 93);
            txtTenRole.Name = "txtTenRole";
            txtTenRole.Size = new Size(172, 27);
            txtTenRole.TabIndex = 92;
            txtTenRole.TextChanged += txtTenRole_TextChanged;
            // 
            // lstQuyenRole
            // 
            lstQuyenRole.Location = new Point(401, 427);
            lstQuyenRole.Name = "lstQuyenRole";
            lstQuyenRole.Size = new Size(230, 64);
            lstQuyenRole.TabIndex = 93;
            lstQuyenRole.SelectedIndexChanged += lstQuyenRole_SelectedIndexChanged;
            // 
            // btnXemQuyenRole
            // 
            btnXemQuyenRole.Location = new Point(463, 497);
            btnXemQuyenRole.Name = "btnXemQuyenRole";
            btnXemQuyenRole.Size = new Size(100, 37);
            btnXemQuyenRole.TabIndex = 94;
            btnXemQuyenRole.Text = "Xem";
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(29, 504);
            btnTiep.Name = "btnQuayLai";
            btnTiep.Size = new Size(125, 38);
            btnTiep.TabIndex = 95;
            btnTiep.Text = "Quay lại";
            btnTiep.Click += btnQuayLai_Click;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(cbFunctThuHoi);
            panel7.Controls.Add(cbViewThuHoi);
            panel7.Controls.Add(cbProcThuHoi);
            panel7.Controls.Add(cbTableThuHoi);
            panel7.Location = new Point(788, 136);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 60);
            panel7.TabIndex = 123;
            // 
            // cbFunctThuHoi
            // 
            cbFunctThuHoi.AutoSize = true;
            cbFunctThuHoi.Location = new Point(121, 33);
            cbFunctThuHoi.Name = "cbFunctThuHoi";
            cbFunctThuHoi.Size = new Size(66, 24);
            cbFunctThuHoi.TabIndex = 3;
            cbFunctThuHoi.Text = "Funct";
            cbFunctThuHoi.UseVisualStyleBackColor = true;
            cbFunctThuHoi.CheckedChanged += cbFunctThuHoi_CheckedChanged;
            // 
            // cbViewThuHoi
            // 
            cbViewThuHoi.AutoSize = true;
            cbViewThuHoi.Location = new Point(121, 3);
            cbViewThuHoi.Name = "cbViewThuHoi";
            cbViewThuHoi.Size = new Size(63, 24);
            cbViewThuHoi.TabIndex = 2;
            cbViewThuHoi.Text = "View";
            cbViewThuHoi.UseVisualStyleBackColor = true;
            cbViewThuHoi.CheckedChanged += cbViewThuHoi_CheckedChanged;
            // 
            // cbProcThuHoi
            // 
            cbProcThuHoi.AutoSize = true;
            cbProcThuHoi.Location = new Point(3, 33);
            cbProcThuHoi.Name = "cbProcThuHoi";
            cbProcThuHoi.Size = new Size(60, 24);
            cbProcThuHoi.TabIndex = 1;
            cbProcThuHoi.Text = "Proc";
            cbProcThuHoi.UseVisualStyleBackColor = true;
            cbProcThuHoi.CheckedChanged += cbProcThuHoi_CheckedChanged;
            // 
            // cbTableThuHoi
            // 
            cbTableThuHoi.AutoSize = true;
            cbTableThuHoi.Location = new Point(3, 3);
            cbTableThuHoi.Name = "cbTableThuHoi";
            cbTableThuHoi.Size = new Size(66, 24);
            cbTableThuHoi.TabIndex = 0;
            cbTableThuHoi.Text = "Table";
            cbTableThuHoi.UseVisualStyleBackColor = true;
            cbTableThuHoi.CheckedChanged += cbTableThuHoi_CheckedChanged;
            // 
            // QuanLyQuyen
            // 
            ClientSize = new Size(1049, 566);
            Controls.Add(panel7);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtTenDoiTuongThuHoi);
            Controls.Add(txtTenCotTableThuHoi);
            Controls.Add(panel4);
            Controls.Add(label7);
            Controls.Add(lbThuHoi);
            Controls.Add(label10);
            Controls.Add(txtThuHoi);
            Controls.Add(btnCapRole);
            Controls.Add(btnCapQuyen);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtTenDoiTuongCapQuyen);
            Controls.Add(txtTenCotTableCapQuyen);
            Controls.Add(panel3);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(lbCapQuyen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(txtCapQuyen);
            Controls.Add(txtTenUser);
            Controls.Add(lstQuyenUser);
            Controls.Add(btnXemQuyenUser);
            Controls.Add(txtTenRole);
            Controls.Add(lstQuyenRole);
            Controls.Add(btnXemQuyenRole);
            Controls.Add(btnTiep);
            Controls.Add(panel1);
            Name = "QuanLyQuyen";
            Load += QuanLyQuyen_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        private Panel panel1;
        private Button button3;
        private Label label2;
        private Label label6;
        private TextBox txtTenDoiTuongThuHoi;
        private TextBox txtTenCotTableThuHoi;
        private Panel panel4;
        private CheckBox cbDeleteThuHoi;
        private CheckBox cbInsertThuHoi;
        private CheckBox cbUpdateThuHoi;
        private CheckBox cbSelectThuHoi;
        private Label label7;
        private Label lbThuHoi;
        private Label label10;
        private TextBox txtThuHoi;
        private Button btnCapRole;
        private Button btnCapQuyen;
        private Label label14;
        private Label label15;
        private TextBox txtTenDoiTuongCapQuyen;
        private TextBox txtTenCotTableCapQuyen;
        private Panel panel3;
        private CheckBox cbDeleteCapQuyen;
        private CheckBox cbInsertCapQuyen;
        private CheckBox cbUpdateCapQuyen;
        private CheckBox cbSelectCapQuyen;
        private Label label13;
        private Panel panel2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label lbCapQuyen;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblTitle;
        private TextBox txtCapQuyen;
        private TextBox txtTenUser;
        private ListBox lstQuyenUser;
        private Button btnXemQuyenUser;
        private TextBox txtTenRole;
        private ListBox lstQuyenRole;
        private Button btnXemQuyenRole;
        private Button btnTiep;
        private CheckBox cbGrantOptionCapQuyen;
        private Panel panel6;
        private CheckBox cbFunctCapQuyen;
        private CheckBox cbViewCapQuyen;
        private CheckBox cbProcCapQuyen;
        private CheckBox cbTableCapQuyen;
        private Panel panel7;
        private CheckBox cbFunctThuHoi;
        private CheckBox cbViewThuHoi;
        private CheckBox cbProcThuHoi;
        private CheckBox cbTableThuHoi;

        // Controls declarations nếu cần viết riêng
    }
}
