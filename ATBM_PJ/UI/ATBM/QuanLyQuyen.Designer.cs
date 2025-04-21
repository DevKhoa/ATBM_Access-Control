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
            txtExecuteThuHoi = new CheckBox();
            checkBox6 = new CheckBox();
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
            cbGrantOptionCapQuyen = new CheckBox();
            panel2 = new Panel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label11 = new Label();
            label9 = new Label();
            lbCapQuyen = new Label();
            label4 = new Label();
            label1 = new Label();
            lblTitle = new Label();
            txtTenUser = new TextBox();
            btnXemQuyenUserVaRole = new Button();
            txtTenRole = new TextBox();
            btnTiep = new Button();
            panel7 = new Panel();
            cbFunctThuHoi = new CheckBox();
            cbViewThuHoi = new CheckBox();
            cbProcThuHoi = new CheckBox();
            cbTableThuHoi = new CheckBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button4 = new Button();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button3.Location = new Point(898, 495);
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
            label2.Location = new Point(721, 218);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 121;
            label2.Text = "Tên đối tượng";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(721, 287);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 120;
            label6.Text = "Tên cột Table (nếu có)";
            label6.Click += label6_Click;
            // 
            // txtTenDoiTuongThuHoi
            // 
            txtTenDoiTuongThuHoi.Location = new Point(721, 241);
            txtTenDoiTuongThuHoi.Name = "txtTenDoiTuongThuHoi";
            txtTenDoiTuongThuHoi.Size = new Size(174, 27);
            txtTenDoiTuongThuHoi.TabIndex = 118;
            txtTenDoiTuongThuHoi.TextChanged += txtTenDoiTuongThuHoi_TextChanged;
            // 
            // txtTenCotTableThuHoi
            // 
            txtTenCotTableThuHoi.Location = new Point(721, 310);
            txtTenCotTableThuHoi.Name = "txtTenCotTableThuHoi";
            txtTenCotTableThuHoi.Size = new Size(174, 27);
            txtTenCotTableThuHoi.TabIndex = 119;
            txtTenCotTableThuHoi.TextChanged += txtTenCotTableThuHoi_TextChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtExecuteThuHoi);
            panel4.Controls.Add(checkBox6);
            panel4.Controls.Add(cbDeleteThuHoi);
            panel4.Controls.Add(cbInsertThuHoi);
            panel4.Controls.Add(cbUpdateThuHoi);
            panel4.Controls.Add(cbSelectThuHoi);
            panel4.Location = new Point(721, 387);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 78);
            panel4.TabIndex = 117;
            // 
            // txtExecuteThuHoi
            // 
            txtExecuteThuHoi.AutoSize = true;
            txtExecuteThuHoi.Location = new Point(176, 3);
            txtExecuteThuHoi.Name = "txtExecuteThuHoi";
            txtExecuteThuHoi.Size = new Size(82, 24);
            txtExecuteThuHoi.TabIndex = 6;
            txtExecuteThuHoi.Text = "Execute";
            txtExecuteThuHoi.UseVisualStyleBackColor = true;
            txtExecuteThuHoi.CheckedChanged += txtExectueThuHoi_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(176, 42);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(117, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Grant Option";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // cbDeleteThuHoi
            // 
            cbDeleteThuHoi.AutoSize = true;
            cbDeleteThuHoi.Location = new Point(98, 42);
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
            cbInsertThuHoi.Location = new Point(98, 3);
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
            label7.Location = new Point(721, 359);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 116;
            label7.Text = "Quyền";
            label7.Click += label7_Click;
            // 
            // lbThuHoi
            // 
            lbThuHoi.AutoSize = true;
            lbThuHoi.Location = new Point(713, 56);
            lbThuHoi.Name = "lbThuHoi";
            lbThuHoi.Size = new Size(101, 20);
            lbThuHoi.TabIndex = 114;
            lbThuHoi.Text = "Tên User/Role";
            lbThuHoi.Click += lbThuHoi_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(713, 113);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 113;
            label10.Text = "Loại đối tượng";
            label10.Click += label10_Click;
            // 
            // txtThuHoi
            // 
            txtThuHoi.Location = new Point(713, 79);
            txtThuHoi.Name = "txtThuHoi";
            txtThuHoi.Size = new Size(174, 27);
            txtThuHoi.TabIndex = 112;
            txtThuHoi.TextChanged += txtThuHoi_TextChanged;
            // 
            // btnCapRole
            // 
            btnCapRole.Location = new Point(402, 191);
            btnCapRole.Name = "btnCapRole";
            btnCapRole.Size = new Size(89, 29);
            btnCapRole.TabIndex = 111;
            btnCapRole.Text = "Cấp quyền";
            btnCapRole.UseVisualStyleBackColor = true;
            btnCapRole.Click += btnCapRole_Click;
            // 
            // btnCapQuyen
            // 
            btnCapQuyen.Location = new Point(78, 218);
            btnCapQuyen.Name = "btnCapQuyen";
            btnCapQuyen.Size = new Size(94, 29);
            btnCapQuyen.TabIndex = 110;
            btnCapQuyen.Text = "Cấp quyền";
            btnCapQuyen.UseVisualStyleBackColor = true;
            btnCapQuyen.Click += btnCapQuyen_Click;
            // 
            // cbGrantOptionCapQuyen
            // 
            cbGrantOptionCapQuyen.AutoSize = true;
            cbGrantOptionCapQuyen.Location = new Point(151, 31);
            cbGrantOptionCapQuyen.Name = "cbGrantOptionCapQuyen";
            cbGrantOptionCapQuyen.Size = new Size(117, 24);
            cbGrantOptionCapQuyen.TabIndex = 4;
            cbGrantOptionCapQuyen.Text = "Grant Option";
            cbGrantOptionCapQuyen.UseVisualStyleBackColor = true;
            cbGrantOptionCapQuyen.CheckedChanged += cbGrantOptionCapQuyen_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbGrantOptionCapQuyen);
            panel2.Controls.Add(checkBox5);
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(33, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 60);
            panel2.TabIndex = 103;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(151, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(80, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Session";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(75, 33);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(66, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Funct";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(75, 3);
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
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
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
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(402, 113);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 101;
            label11.Text = "Tên User";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(402, 56);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 100;
            label9.Text = "Tên Role";
            label9.Click += label9_Click;
            // 
            // lbCapQuyen
            // 
            lbCapQuyen.AutoSize = true;
            lbCapQuyen.Location = new Point(33, 43);
            lbCapQuyen.Name = "lbCapQuyen";
            lbCapQuyen.Size = new Size(101, 20);
            lbCapQuyen.TabIndex = 99;
            lbCapQuyen.Text = "Tên User/Role";
            lbCapQuyen.Click += lbCapQuyen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 113);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 98;
            label4.Text = "Loại đối tượng";
            label4.Click += label4_Click;
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
            lblTitle.Location = new Point(6, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 20);
            lblTitle.TabIndex = 87;
            lblTitle.Text = "Quản lý User/Role";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtTenUser
            // 
            txtTenUser.Location = new Point(402, 145);
            txtTenUser.Name = "txtTenUser";
            txtTenUser.Size = new Size(194, 27);
            txtTenUser.TabIndex = 89;
            txtTenUser.TextChanged += txtTenUser_TextChanged_1;
            // 
            // btnXemQuyenUserVaRole
            // 
            btnXemQuyenUserVaRole.Location = new Point(402, 495);
            btnXemQuyenUserVaRole.Name = "btnXemQuyenUserVaRole";
            btnXemQuyenUserVaRole.Size = new Size(194, 38);
            btnXemQuyenUserVaRole.TabIndex = 91;
            btnXemQuyenUserVaRole.Text = "Xem quyền User và Role";
            btnXemQuyenUserVaRole.Click += BtnXemQuyenUser_Click;
            // 
            // txtTenRole
            // 
            txtTenRole.Location = new Point(402, 79);
            txtTenRole.Name = "txtTenRole";
            txtTenRole.Size = new Size(194, 27);
            txtTenRole.TabIndex = 92;
            txtTenRole.TextChanged += txtTenRole_TextChanged;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(15, 516);
            btnTiep.Name = "btnTiep";
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
            panel7.Location = new Point(717, 145);
            panel7.Name = "panel7";
            panel7.Size = new Size(199, 60);
            panel7.TabIndex = 123;
            panel7.Paint += panel7_Paint;
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
            // button1
            // 
            button1.Location = new Point(757, 495);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 124;
            button1.Text = "Cấp quyền";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(262, 52);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 125;
            radioButton1.TabStop = true;
            radioButton1.Text = "User";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(262, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 24);
            radioButton2.TabIndex = 126;
            radioButton2.TabStop = true;
            radioButton2.Text = "Role";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 127;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(563, 167);
            dataGridView1.TabIndex = 128;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 464);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 129;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 441);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 130;
            label3.Text = "Nhập tên User/Role";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 464);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 131;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 441);
            label5.Name = "label5";
            label5.Size = new Size(198, 20);
            label5.TabIndex = 132;
            label5.Text = "Nhập quyền TAB/ SYS/ ROLE";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(502, 191);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 133;
            button2.Text = "Thu hồi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(197, 218);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 134;
            button4.Text = "Thu hồi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // QuanLyQuyen
            // 
            ClientSize = new Size(1049, 566);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
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
            Controls.Add(panel2);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(lbCapQuyen);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(txtTenUser);
            Controls.Add(btnXemQuyenUserVaRole);
            Controls.Add(txtTenRole);
            Controls.Add(btnTiep);
            Controls.Add(panel1);
            Name = "QuanLyQuyen";
            Load += QuanLyQuyen_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label11;
        private Label label9;
        private Label lbCapQuyen;
        private Label label4;
        private Label label1;
        private Label lblTitle;
        private TextBox txtTenUser;
        private Button btnXemQuyenUserVaRole;
        private TextBox txtTenRole;
        private Button btnTiep;
        private CheckBox cbGrantOptionCapQuyen;
        private Panel panel7;
        private CheckBox cbFunctThuHoi;
        private CheckBox cbViewThuHoi;
        private CheckBox cbProcThuHoi;
        private CheckBox cbTableThuHoi;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private CheckBox txtExecuteThuHoi;
        private Button button2;
        private Button button4;

        // Controls declarations nếu cần viết riêng
    }
}
