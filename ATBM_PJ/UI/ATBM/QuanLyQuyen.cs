using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATBM
{
    public partial class QuanLyQuyen : Form
    {
        public QuanLyQuyen()
        {
            InitializeComponent();
        }

        private void txtTenUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDoiTuongCapQuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCotTableCapQuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSelectCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbUpdateCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbGrantOptionCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbInsertCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDeleteCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            // Cấp quyền hệ thống
            string tenDoiTuong = textBox1.Text.ToUpper();

            if (string.IsNullOrEmpty(tenDoiTuong))
            {
                MessageBox.Show("Vui lòng nhập tên User hoặc Role.");
                return;
            }

            List<(CheckBox chk, string quyen)> danhSachQuyen = new()
            {
                (checkBox1, "CREATE TABLE"),
                (checkBox3, "CREATE VIEW"),
                (checkBox2, "CREATE PROCEDURE"),
                (checkBox4, "CREATE FUNCTION"),
                (checkBox5, "CREATE SESSION")
            };

            bool withGrantOption = cbGrantOptionCapQuyen.Checked;
            bool hasError = false;

            using OracleConnection conn = OracleHelper.GetConnection();
            conn.Open();

            foreach (var (chk, quyen) in danhSachQuyen)
            {
                if (!chk.Checked) continue;

                using OracleCommand cmd = conn.CreateCommand();

                if (radioButton1.Checked)
                {
                    cmd.CommandText = "grant_priv_to_user";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = tenDoiTuong;
                    cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = quyen;
                    cmd.Parameters.Add("p_with_grant", OracleDbType.Boolean).Value = withGrantOption;
                }
                else if (radioButton2.Checked)
                {
                    cmd.CommandText = "grant_priv_to_role";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = tenDoiTuong;
                    cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = quyen;
                    cmd.Parameters.Add("p_with_admin", OracleDbType.Boolean).Value = withGrantOption;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn User hoặc Role.");
                    return;
                }

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    hasError = true;
                    MessageBox.Show($"Lỗi khi cấp quyền {quyen}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!hasError)
            {
                MessageBox.Show("Đã cấp quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTenRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCapRole_Click(object sender, EventArgs e)
        {
            // Cấp role cho user
            string role = txtTenRole.Text.Trim().ToUpper();
            string username = txtTenUser.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên Role và Tên User.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                conn.Open();

                using OracleCommand cmd = new OracleCommand("grant_role_to_user", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                cmd.ExecuteNonQuery();

                MessageBox.Show($"Đã cấp role `{role}` cho user `{username}`.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi Oracle: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTableCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbViewCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFunctCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbProcCapQuyen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstQuyenUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnXemQuyenUser_Click(object sender, EventArgs e)
        {
            // Xem quyền của user hoặc role
            string grantee = textBox2.Text.Trim().ToUpper();    // Nhập user hoặc role
            string typeFilter = textBox3.Text.Trim().ToUpper(); // TAB, SYS, ROLE, COL hoặc trống

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                {
                    conn.Open();

                    List<string> queries = new();

                    // TABLE privileges
                    if (typeFilter == "TAB" || string.IsNullOrEmpty(typeFilter))
                    {
                        queries.Add(@"
                    SELECT  
                        GRANTEE,
                        TABLE_NAME AS OBJECT_NAME,
                        PRIVILEGE,
                        'TABLE_PRIV' AS PRIV_TYPE,
                        GRANTABLE
                    FROM DBA_TAB_PRIVS
                    WHERE (:grantee IS NULL OR GRANTEE = :grantee)
                ");
                    }

                    // SYSTEM privileges
                    if (typeFilter == "SYS" || string.IsNullOrEmpty(typeFilter))
                    {
                        queries.Add(@"
                    SELECT  
                        GRANTEE,
                        NULL AS OBJECT_NAME,
                        PRIVILEGE,
                        'SYS_PRIV' AS PRIV_TYPE,
                        ADMIN_OPTION AS GRANTABLE
                    FROM DBA_SYS_PRIVS
                    WHERE (:grantee IS NULL OR GRANTEE = :grantee)
                ");
                    }

                    // ROLE privileges
                    if (typeFilter == "ROLE" || string.IsNullOrEmpty(typeFilter))
                    {
                        queries.Add(@"
                    SELECT  
                        GRANTEE,
                        GRANTED_ROLE AS OBJECT_NAME,
                        'ROLE' AS PRIVILEGE,
                        'ROLE_PRIV' AS PRIV_TYPE,
                        ADMIN_OPTION AS GRANTABLE
                    FROM DBA_ROLE_PRIVS
                    WHERE (:grantee IS NULL OR GRANTEE = :grantee)
                ");
                    }

                    // COLUMN privileges
                    if (typeFilter == "COL" || string.IsNullOrEmpty(typeFilter))
                    {
                        queries.Add(@"
                    SELECT  
                        GRANTEE,
                        TABLE_NAME || '.' || COLUMN_NAME AS OBJECT_NAME,
                        PRIVILEGE,
                        'COL_PRIV' AS PRIV_TYPE,
                        GRANTABLE
                    FROM DBA_COL_PRIVS
                    WHERE (:grantee IS NULL OR GRANTEE = :grantee)
                ");
                    }

                    string fullQuery = string.Join(" UNION ALL ", queries) + " ORDER BY GRANTEE, PRIV_TYPE, OBJECT_NAME";

                    OracleCommand cmd = new(fullQuery, conn)
                    {
                        BindByName = true
                    };

                    if (string.IsNullOrEmpty(grantee))
                        cmd.Parameters.Add("grantee", OracleDbType.Varchar2).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("grantee", OracleDbType.Varchar2).Value = grantee;

                    OracleDataAdapter adapter = new(cmd);
                    DataTable dt = new();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy quyền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstQuyenRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThuHoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTableThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbViewThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbProcThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbFunctThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDoiTuongThuHoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCotTableThuHoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSelectThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbInsertThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbUpdateThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDeleteThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Thu hồi quyền trên đối tượng
            string grantee = txtThuHoi.Text.Trim();
            string objectName = txtTenDoiTuongThuHoi.Text.Trim();
            string columnName = txtTenCotTableThuHoi.Text.Trim();
            string objectType = "";
            List<string> privileges = new List<string>();

            if (cbTableThuHoi.Checked) objectType = "TABLE";
            else if (cbViewThuHoi.Checked) objectType = "VIEW";
            else if (cbProcThuHoi.Checked) objectType = "PROCEDURE";
            else if (cbFunctThuHoi.Checked) objectType = "FUNCTION";

            if (cbSelectThuHoi.Checked) privileges.Add("SELECT");
            if (cbInsertThuHoi.Checked) privileges.Add("INSERT");
            if (cbUpdateThuHoi.Checked) privileges.Add("UPDATE");
            if (cbDeleteThuHoi.Checked) privileges.Add("DELETE");
            if (txtExecuteThuHoi.Checked) privileges.Add("EXECUTE");

            if (string.IsNullOrEmpty(grantee) || string.IsNullOrEmpty(objectName) || string.IsNullOrEmpty(objectType) || privileges.Count == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasError = false;

            using OracleConnection conn = OracleHelper.GetConnection();
            {
                try
                {
                    conn.Open();
                    foreach (var priv in privileges)
                    {
                        string sql = $"REVOKE {priv}";

                        // Chỉ SELECT và UPDATE mới có thể thu hồi trên cột
                        if (!string.IsNullOrEmpty(columnName) && (priv == "SELECT" || priv == "UPDATE"))
                        {
                            sql += $"({columnName})";
                        }

                        sql += $" ON \"{objectName}\" FROM \"{grantee}\"";

                        try
                        {
                            using OracleCommand cmd = new(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            hasError = true;
                            MessageBox.Show($"Lỗi khi thu hồi {priv} trên {objectName}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (!hasError)
                        MessageBox.Show("Thu hồi quyền thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void QuanLyQuyen_Load(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbCapQuyen_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbThuHoi_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cấp quyền trên đối tượng
            string grantee = txtThuHoi.Text.Trim().ToUpper();
            string objectName = txtTenDoiTuongThuHoi.Text.Trim().ToUpper();
            string columns = txtTenCotTableThuHoi.Text.Trim(); // để trống nếu không cấp theo cột

            // Lấy quyền được chọn
            List<string> privileges = new List<string>();
            if (cbSelectThuHoi.Checked) privileges.Add("SELECT");
            if (cbInsertThuHoi.Checked) privileges.Add("INSERT");
            if (cbUpdateThuHoi.Checked) privileges.Add("UPDATE");
            if (cbDeleteThuHoi.Checked) privileges.Add("DELETE");
            if (txtExecuteThuHoi.Checked) privileges.Add("EXECUTE");

            bool withGrantOption = checkBox6.Checked;

            // Xác định loại đối tượng
            string objType = "";
            if (cbTableThuHoi.Checked) objType = "TABLE";
            else if (cbViewThuHoi.Checked) objType = "VIEW";
            else if (cbProcThuHoi.Checked) objType = "PROCEDURE";
            else if (cbFunctThuHoi.Checked) objType = "FUNCTION";

            bool hasError = false;

            // ==== KIỂM TRA HỢP LỆ TRƯỚC ====

            if (string.IsNullOrEmpty(grantee) || string.IsNullOrEmpty(objectName) || privileges.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu là FUNCTION hoặc PROCEDURE
            if ((objType == "FUNCTION" || objType == "PROCEDURE"))
            {
                if (privileges.Count != 1 || privileges[0] != "EXECUTE")
                {
                    MessageBox.Show("Chỉ được cấp quyền EXECUTE cho FUNCTION hoặc PROCEDURE.", "Lỗi quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(columns))
                {
                    MessageBox.Show("Không được nhập cột khi cấp quyền EXECUTE cho FUNCTION/PROCEDURE.", "Lỗi cột", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Nếu có nhập cột, chỉ cho phép SELECT hoặc UPDATE
            if (!string.IsNullOrEmpty(columns))
            {
                foreach (string priv in privileges)
                {
                    if (priv != "SELECT" && priv != "UPDATE")
                    {
                        MessageBox.Show("Chỉ có thể cấp quyền SELECT hoặc UPDATE theo cột.\nBạn đang nhập cột cho quyền: " + priv,
                                        "Lỗi quyền theo cột", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // ==== GỌI STORED PROCEDURE ====

            try
            {
                using OracleConnection conn = OracleHelper.GetConnection();
                {
                    conn.Open();

                    foreach (string priv in privileges)
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conn;

                        if (!string.IsNullOrEmpty(columns) && (priv == "SELECT" || priv == "UPDATE") && (objType == "TABLE" || objType == "VIEW"))
                        {
                            // Gọi procedure cấp quyền theo cột
                            cmd.CommandText = "grant_column_privileges";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = priv;
                            cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value = objectName;
                            cmd.Parameters.Add("p_column_list", OracleDbType.Varchar2).Value = columns;
                            cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                            cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = withGrantOption;
                        }
                        else
                        {
                            // Gọi procedure cấp quyền object thông thường
                            cmd.CommandText = "grant_obj_priv";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = priv;
                            cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value = objectName;
                            cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                            cmd.Parameters.Add("p_with_grant", OracleDbType.Boolean).Value = withGrantOption;
                        }

                        cmd.ExecuteNonQuery();
                    }
                    if (!hasError)
                        MessageBox.Show("Cấp quyền thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cấp quyền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtExectueThuHoi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Thu hồi quyền hệ thống
            string grantee = textBox1.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(grantee))
            {
                MessageBox.Show("Vui lòng nhập tên User hoặc Role.");
                return;
            }

            List<string> privilegesToRevoke = new List<string>();
            if (checkBox1.Checked) privilegesToRevoke.Add("CREATE TABLE");
            if (checkBox3.Checked) privilegesToRevoke.Add("CREATE VIEW");
            if (checkBox2.Checked) privilegesToRevoke.Add("CREATE PROCEDURE");
            if (checkBox4.Checked) privilegesToRevoke.Add("CREATE FUNCTION");
            if (checkBox5.Checked) privilegesToRevoke.Add("CREATE SESSION");

            if (privilegesToRevoke.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một quyền để thu hồi.");
                return;
            }

            bool hasError = false;

            using (OracleConnection conn = OracleHelper.GetConnection())
            {
                conn.Open();

                foreach (string priv in privilegesToRevoke)
                {
                    using (OracleCommand cmd = new OracleCommand("revoke_sys_privilege", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_privilege_name", OracleDbType.Varchar2).Value = priv;
                        cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            hasError = true;
                            MessageBox.Show($"❌ Lỗi thu hồi quyền {priv}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            if (!hasError)
            {
                MessageBox.Show("✅ Đã thu hồi quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Thu hồi role từ user
            string grantee = txtTenUser.Text.Trim();
            string roleName = txtTenRole.Text.Trim();

            if (grantee == "" || roleName == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using OracleConnection conn = OracleHelper.GetConnection();
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("revoke_role", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                    cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thu hồi role " + roleName + " từ " + grantee);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
