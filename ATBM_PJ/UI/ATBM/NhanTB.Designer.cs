namespace ATBM
{
    partial class NhanTB
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnQuayLai;


        private void InitializeComponent()
        {
            btnQuayLai = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(25, 354);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(90, 30);
            btnQuayLai.TabIndex = 5;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 238);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(273, 306);
            button1.Name = "button1";
            button1.Size = new Size(103, 50);
            button1.TabIndex = 7;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NhanTB
            // 
            ClientSize = new Size(631, 403);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnQuayLai);
            Name = "NhanTB";
            Text = "Nhận thông báo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridView1;
        private Button button1;
    }
}
