using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            QuanLyQuyen f = new QuanLyQuyen();
            f.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void btnTiep_Click_1(object sender, EventArgs e)
        {
            QuanLyQuyen f = new QuanLyQuyen();
            f.Show();
            this.Hide();
        }

        private void lblTenUser_Click(object sender, EventArgs e)
        {

        }

        private void txtTenUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoUser_Click(object sender, EventArgs e)
        {
            string username = txtTenUser.Text.Trim().ToUpper();
            string password = txtMatKhau.Text.Trim();
            bool hasError = false;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên user và mật khẩu.");
                return;
            }

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                {
                    conn.Open();
                    using OracleCommand cmd = new OracleCommand("create_user", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                hasError = true;
                MessageBox.Show("Lỗi khi tạo user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!hasError)
            {
                MessageBox.Show("Tạo user thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            string username = txtTenUser.Text.Trim().ToUpper();
            bool hasError = false;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên user cần xóa.");
                return;
            }

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                {
                    conn.Open();
                    using OracleCommand cmd = new OracleCommand("drop_user", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                hasError = true;
                MessageBox.Show("Lỗi khi xóa user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!hasError)
            {
                MessageBox.Show("Xóa user thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXemUser_Click(object sender, EventArgs e)
        {
            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                {
                    conn.Open();
                    string query = "SELECT username, account_status, created FROM dba_users ORDER BY created DESC";

                    using OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xem danh sách user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblUserCu_Click(object sender, EventArgs e)
        {

        }

        private void txtUserCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMKCu_Click(object sender, EventArgs e)
        {

        }

        private void lblUserMoi_Click(object sender, EventArgs e)
        {

        }

        private void txtUserMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMKMoi_Click(object sender, EventArgs e)
        {

        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhatUser_Click(object sender, EventArgs e)
        {
            string username = txtUserCu.Text.Trim();
            string newPassword = txtMKMoi.Text.Trim();

            if (username == "" || newPassword == "")
            {
                MessageBox.Show("Vui lòng nhập tên user và mật khẩu mới.");
                return;
            }

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("change_user_password", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    cmd.Parameters.Add("p_new_password", OracleDbType.Varchar2).Value = newPassword;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã đổi mật khẩu user thành công.");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lblTenRole_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoRole_Click(object sender, EventArgs e)
        {
            string roleName = txtTenRole.Text.Trim();
            string? password = checkBox1.Checked ? textBox1.Text.Trim() : null;

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên role.");
                return;
            }

            using (OracleConnection conn = OracleHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("create_role", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(password) ? (object)DBNull.Value : password;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo role thành công.");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaRole_Click(object sender, EventArgs e)
        {
            string roleName = txtTenRole.Text.Trim();
            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên role.");
                return;
            }

            using OracleConnection conn = OracleHelper.GetConnection();
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("drop_role", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa role thành công.");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXemRole_Click(object sender, EventArgs e)
        {
            using OracleConnection conn = OracleHelper.GetConnection();
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM dba_roles ORDER BY role";
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void lstRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRoleCu_Click(object sender, EventArgs e)
        {

        }

        private void txtRoleCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRoleMoi_Click(object sender, EventArgs e)
        {

        }

        private void txtRoleMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhatRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleCu.Text.Trim();
            string newPassword = txtRoleMoi.Text.Trim();

            if (roleName == "" || newPassword == "")
            {
                MessageBox.Show("Vui lòng nhập tên role và mật khẩu mới.");
                return;
            }

            try
            {
                using (OracleConnection conn = OracleHelper.GetConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("change_role_password", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                    cmd.Parameters.Add("p_new_password", OracleDbType.Varchar2).Value = newPassword;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã đổi mật khẩu role thành công.");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
