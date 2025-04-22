using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace ATBM
{
    public partial class QLMM : Form
    {
        public QLMM()
        {
            InitializeComponent();
        }

        private void QLMM_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string filter = txtMaMoMon.Text.Trim();

            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"
                BEGIN 
                  ADMIN_PJ.PRC_SEARCH_MOMON_ROLE(:p_cursor, :p_mamm); 
                END;";
                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value =
                        string.IsNullOrEmpty(filter) ? DBNull.Value : (object)filter;

                    var adapter = new OracleDataAdapter((OracleCommand)cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvMoMon.DataSource = table;

                    if (table.Rows.Count > 0)
                        FillFormWithRow(table.Rows[0], table.Columns);
                }
            }
        }

        private void FillFormWithRow(DataRow row, DataColumnCollection cols)
        {
            if (cols.Contains("MAMM")) txtMaMoMon.Text = row["MAMM"].ToString();
            if (cols.Contains("MAHP")) txtMaHP.Text = row["MAHP"].ToString();
            if (cols.Contains("MAGV")) txtGiangVien.Text = row["MAGV"].ToString();
            if (cols.Contains("HK")) cbHocKy.Text = row["HK"].ToString();
            if (cols.Contains("NAM")) txtNamHoc.Text = row["NAM"].ToString();
        }


        private void dgvMoMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMoMon.CurrentRow != null && dgvMoMon.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvMoMon.CurrentRow;

                txtMaMoMon.Text = row.Cells["MAMM"].Value?.ToString() ?? "";
                txtMaHP.Text = row.Cells["MAHP"].Value?.ToString() ?? "";
                txtGiangVien.Text = row.Cells["MAGV"].Value?.ToString() ?? "";
                cbHocKy.Text = row.Cells["HK"].Value?.ToString() ?? "";
                txtNamHoc.Text = row.Cells["NAM"].Value?.ToString() ?? "";
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // NV_PDT mới có quyền
            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        BEGIN 
                          ADMIN_PJ.PRC_INSERT_MONMO(
                            :p_mamm, :p_mahp, :p_gv,
                            :p_hocky, :p_namhoc
                        ); 
                        END;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = txtMaMoMon.Text.Trim();
                    cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = txtMaHP.Text.Trim();
                    cmd.Parameters.Add("p_gv", OracleDbType.Varchar2).Value = txtGiangVien.Text.Trim();
                    cmd.Parameters.Add("p_hocky", OracleDbType.Varchar2).Value = cbHocKy.SelectedItem?.ToString() ?? "";
                    cmd.Parameters.Add("p_namhoc", OracleDbType.Varchar2).Value = txtNamHoc.Text.Trim();

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            dgvMoMon.DataSource = null;
            dgvMoMon.Rows.Clear();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMoMon.CurrentRow == null) return;
            string id = dgvMoMon.CurrentRow.Cells["MAMM"].Value.ToString();

            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                      BEGIN 
                        ADMIN_PJ.PRC_DELETE_MONMO(:p_mamm); 
                      END;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = id;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvMoMon.CurrentRow == null) return;
            string id = dgvMoMon.CurrentRow.Cells["MAMM"].Value.ToString();

            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        BEGIN 
                          ADMIN_PJ.PRC_UPDATE_MONMO(
                            :p_mamm, :p_mahp, :p_gv,
                            :p_hocky, :p_namhoc
                        ); 
                        END;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = id;
                    cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = txtMaHP.Text.Trim();
                    cmd.Parameters.Add("p_gv", OracleDbType.Varchar2).Value = txtGiangVien.Text.Trim();
                    cmd.Parameters.Add("p_hocky", OracleDbType.Varchar2).Value = cbHocKy.SelectedItem?.ToString() ?? "";
                    cmd.Parameters.Add("p_namhoc", OracleDbType.Varchar2).Value = txtNamHoc.Text.Trim();

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadData();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            this.Close();
        }

    }
}
