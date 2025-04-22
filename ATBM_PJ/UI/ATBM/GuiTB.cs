using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class GuiTB : Form
    {
        public GuiTB()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xử lý thêm thông báo mới
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xử lý xóa thông báo
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm thông báo
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            // Xử lý gửi thông báo
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GuiTB_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idText = textBox1.Text.Trim();
            string noiDung = textBox2.Text.Trim();
            string doiTuong = textBox3.Text.Trim().ToUpper();
            string donVi = textBox4.Text.Trim().ToUpper();
            string coSo = textBox5.Text.Trim().ToUpper();

            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(idText) ||
                string.IsNullOrWhiteSpace(noiDung) ||
                string.IsNullOrWhiteSpace(doiTuong) ||
                string.IsNullOrWhiteSpace(donVi) ||
                string.IsNullOrWhiteSpace(coSo))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra ID hợp lệ
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("ID phải là số nguyên hợp lệ.");
                return;
            }

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                conn.Open();

                using OracleCommand cmd = new OracleCommand("THEM_THONGBAO", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                // Truyền tham số
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("p_noidung", OracleDbType.Varchar2).Value = noiDung;
                cmd.Parameters.Add("p_doituong", OracleDbType.Varchar2).Value = doiTuong;
                cmd.Parameters.Add("p_donvi", OracleDbType.Varchar2).Value = donVi;
                cmd.Parameters.Add("p_coso", OracleDbType.Varchar2).Value = coSo;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Gửi thông báo thành công!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
