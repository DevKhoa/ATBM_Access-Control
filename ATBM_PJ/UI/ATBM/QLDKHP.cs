using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Data;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QLDKHP : Form
    {
        OracleConnection conn;
        string connStr = "Data Source=localhost:1521/22127197_470_247;User Id=ADMIN_PJ;Password=123;";

        public QLDKHP()
        {
            InitializeComponent();
            conn = new OracleConnection(connStr);
            LoadHocPhan();
            LoadDonVi();
        }

        private void LoadDonVi()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT MADV, TENDV FROM ADMIN_PJ.DONVI WHERE LOAIDV = 'Khoa'", conn);
                OracleDataReader dr = cmd.ExecuteReader();

                // Clear ComboBox trước khi thêm mới dữ liệu
                cbDonVi.Items.Clear();

                while (dr.Read())
                {
                    // Thêm các giá trị vào ComboBox: hiển thị tên đơn vị và lưu mã đơn vị
                    cbDonVi.Items.Add(new { Text = dr["TENDV"].ToString(), Value = dr["MADV"].ToString() });
                }

                // Thiết lập để ComboBox hiển thị tên và lưu giá trị đúng
                cbDonVi.DisplayMember = "Text";
                cbDonVi.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn vị: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void LoadHocPhan()
        {
            dgvHocPhan.Rows.Clear();

            try
            {
                conn.Open();
                string query = @"
            SELECT HP.MAHP, HP.TENHP, HP.SOTC, HP.STLT, HP.STTH,
                   NV.HOTEN AS GIANGVIEN, HP.MADV
            FROM ADMIN_PJ.HOCPHAN HP
            LEFT JOIN ADMIN_PJ.MOMON MM ON HP.MAHP = MM.MAHP
            LEFT JOIN ADMIN_PJ.NHANVIEN NV ON MM.MAGV = NV.MANV";

                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvHocPhan.Rows.Add(
                        dr["MAHP"].ToString(),
                        dr["TENHP"].ToString(),
                        dr["SOTC"].ToString(),
                        dr["STLT"].ToString(),
                        dr["STTH"].ToString(),
                        dr["MADV"].ToString(),
                        dr["GIANGVIEN"] == DBNull.Value ? "" : dr["GIANGVIEN"].ToString()
                        
                    );
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải học phần: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }





        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ADMIN_PJ.prc_insert_hocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào stored procedure
                cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = txtMaHP.Text;
                cmd.Parameters.Add("p_tenhp", OracleDbType.NVarchar2).Value = txtTenHP.Text;
                cmd.Parameters.Add("p_sotc", OracleDbType.Int32).Value = int.Parse(txtSoTinChi.Text);
                cmd.Parameters.Add("p_stlt", OracleDbType.Int32).Value = int.Parse(txtSoTLT.Text);
                cmd.Parameters.Add("p_stth", OracleDbType.Int32).Value = int.Parse(txtSoLTH.Text);
                cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value = ((dynamic)cbDonVi.SelectedItem).Value.ToString(); // Lấy mã đơn vị từ ComboBox

                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm học phần thành công.");
                ClearFields();  // Xóa các trường thông tin sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm học phần: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadHocPhan();  // Tải lại danh sách học phần
            }
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã học phần.");
                return;
            }

            try
            {
                conn.Open();

                // Kiểm tra học phần có tồn tại không
                OracleCommand checkCmd = new OracleCommand("SELECT COUNT(*) FROM ADMIN_PJ.HOCPHAN WHERE MAHP = :mahp", conn);
                checkCmd.Parameters.Add("mahp", txtMaHP.Text);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Mã học phần không tồn tại.");
                    return;
                }

                // Lấy MADV cũ nếu không chọn đơn vị mới
                string madv = null;
                if (string.IsNullOrWhiteSpace(cbDonVi.Text))
                {
                    OracleCommand getOldDV = new OracleCommand("SELECT MADV FROM ADMIN_PJ.HOCPHAN WHERE MAHP = :mahp", conn);
                    getOldDV.Parameters.Add("mahp", txtMaHP.Text);
                    object result = getOldDV.ExecuteScalar();
                    madv = result != null ? result.ToString() : null;
                }
                else
                {
                    madv = cbDonVi.SelectedValue.ToString();
                }

                OracleCommand cmd = new OracleCommand("ADMIN_PJ.prc_update_hocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = txtMaHP.Text;

                cmd.Parameters.Add("p_tenhp", OracleDbType.NVarchar2).Value =
                    string.IsNullOrWhiteSpace(txtTenHP.Text) ? DBNull.Value : (object)txtTenHP.Text;

                cmd.Parameters.Add("p_sotc", OracleDbType.Int32).Value =
                    string.IsNullOrWhiteSpace(txtSoTinChi.Text) ? DBNull.Value : Convert.ToInt32(txtSoTinChi.Text);

                cmd.Parameters.Add("p_stlt", OracleDbType.Int32).Value =
                    string.IsNullOrWhiteSpace(txtSoTLT.Text) ? DBNull.Value : Convert.ToInt32(txtSoTLT.Text);

                cmd.Parameters.Add("p_stth", OracleDbType.Int32).Value =
                    string.IsNullOrWhiteSpace(txtSoLTH.Text) ? DBNull.Value : Convert.ToInt32(txtSoLTH.Text);

                cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value =
                    string.IsNullOrWhiteSpace(madv) ? DBNull.Value : madv;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật học phần thành công.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật học phần: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadHocPhan();
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã học phần cần xóa.");
                return;
            }

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ADMIN_PJ.prc_delete_hocphan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_mahp", OracleDbType.Varchar2).Value = txtMaHP.Text;

                OracleParameter p_rowcount = new OracleParameter("p_rowcount", OracleDbType.Int32);
                p_rowcount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p_rowcount);

                cmd.ExecuteNonQuery();

                int rowsAffected = ((OracleDecimal)p_rowcount.Value).ToInt32();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy học phần có mã: " + txtMaHP.Text);
                }
                else
                {
                    MessageBox.Show("Xóa thành công.");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadHocPhan();
            }
        }

        private void ClearFields()
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
            txtSoTinChi.Clear();
            txtSoTLT.Clear();
            txtSoLTH.Clear();
            cbDonVi.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHP.Text))
                {
                    LoadHocPhan() ;
                    return;
                }

                conn.Open();
                string keyword = txtMaHP.Text.Trim();

                string query = @"
            SELECT HP.MAHP, HP.TENHP, HP.SOTC, HP.STLT, HP.STTH,
                   NV.HOTEN AS GIANGVIEN, HP.MADV
            FROM ADMIN_PJ.HOCPHAN HP
            LEFT JOIN ADMIN_PJ.MOMON MM ON HP.MAHP = MM.MAHP
            LEFT JOIN ADMIN_PJ.NHANVIEN NV ON MM.MAGV = NV.MANV
            WHERE HP.MAHP = :mahp";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("mahp", OracleDbType.Varchar2).Value = keyword;

                OracleDataReader dr = cmd.ExecuteReader();

                dgvHocPhan.Rows.Clear();

                if (!dr.HasRows)
                {
                    MessageBox.Show("Mã học phần không tồn tại.");
                    return;
                }

                while (dr.Read())
                {
                    dgvHocPhan.Rows.Add(
                        dr["MAHP"].ToString(),
                        dr["TENHP"].ToString(),
                        dr["SOTC"].ToString(),
                        dr["STLT"].ToString(),
                        dr["STTH"].ToString(),
                        dr["MADV"].ToString(),
                        dr["GIANGVIEN"] == DBNull.Value ? "" : dr["GIANGVIEN"].ToString()
                        
                    );
                }

                dr.Close();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Hide();
        }
    }
}
