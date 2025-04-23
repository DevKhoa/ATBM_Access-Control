using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Data;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QLSV : Form
    {
        OracleConnection conn;
        string connStr = "Data Source=localhost:1521/22127197_470_247;User Id=ADMIN_PJ;Password=123;";

        public QLSV()
        {
            InitializeComponent();
            conn = new OracleConnection(connStr);
            LoadData();
            LoadKhoa();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN_PJ.SINHVIEN", conn);
                OracleDataReader dr = cmd.ExecuteReader();

                dgvSinhVien.Rows.Clear(); // Xóa dữ liệu cũ

                while (dr.Read())
                {
                    dgvSinhVien.Rows.Add(
                        dr["MASV"].ToString(),
                        dr["HOTEN"].ToString(),
                        dr["PHAI"].ToString(),
                        Convert.ToDateTime(dr["NGSINH"]).ToString("dd/MM/yyyy"),
                        dr["DCHI"].ToString(),
                        dr["DT"].ToString(),
                        dr["KHOA"].ToString(),
                        dr["TINHTRANG"].ToString()
                    );
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void LoadKhoa()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT MADV FROM ADMIN_PJ.DONVI", conn);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbKhoa.Items.Add(dr["MADV"].ToString());
                }
                dr.Close();
            }
            catch { }
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
                OracleCommand cmd = new OracleCommand("ADMIN_PJ.prc_insert_sinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_masv", txtMaSV.Text);
                cmd.Parameters.Add("p_hoten", txtHoTen.Text);
                cmd.Parameters.Add("p_phai", cbGioiTinh.Text);
                cmd.Parameters.Add("p_ngsinh", dtpNgaySinh.Value);
                cmd.Parameters.Add("p_dchi", txtDiaChi.Text);
                cmd.Parameters.Add("p_dt", txtSDT.Text);
                cmd.Parameters.Add("p_khoa", cbKhoa.Text);
                cmd.Parameters.Add("p_tinhtrang", txtTinhTrangHV.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sinh viên thành công.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên.");
                return;
            }

            try
            {
                conn.Open();

                // Kiểm tra mã sinh viên có tồn tại không
                OracleCommand checkCmd = new OracleCommand("SELECT COUNT(*) FROM ADMIN_PJ.SINHVIEN WHERE MASV = :masv", conn);
                checkCmd.Parameters.Add("masv", txtMaSV.Text);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại.");
                    return;
                }

                OracleCommand cmd = new OracleCommand("ADMIN_PJ.prc_update_sinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_masv", txtMaSV.Text);
                cmd.Parameters.Add("p_hoten", string.IsNullOrWhiteSpace(txtHoTen.Text) ? (object)DBNull.Value : txtHoTen.Text);
                cmd.Parameters.Add("p_phai", string.IsNullOrWhiteSpace(cbGioiTinh.Text) ? (object)DBNull.Value : cbGioiTinh.Text);
                cmd.Parameters.Add("p_ngsinh", dtpNgaySinh.Value); 
                cmd.Parameters.Add("p_dchi", string.IsNullOrWhiteSpace(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text);
                cmd.Parameters.Add("p_dt", string.IsNullOrWhiteSpace(txtSDT.Text) ? (object)DBNull.Value : txtSDT.Text);
                cmd.Parameters.Add("p_khoa", string.IsNullOrWhiteSpace(cbKhoa.Text) ? (object)DBNull.Value : cbKhoa.Text);
                cmd.Parameters.Add("p_tinhtrang", string.IsNullOrWhiteSpace(txtTinhTrangHV.Text) ? (object)DBNull.Value : txtTinhTrangHV.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa.");
                return;
            }

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("ADMIN_PJ.prc_delete_sinhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm parameter đầu vào
                cmd.Parameters.Add("p_masv", OracleDbType.Varchar2).Value = txtMaSV.Text;

                // Thêm parameter trả về số dòng bị ảnh hưởng
                OracleParameter p_rowcount = new OracleParameter("p_rowcount", OracleDbType.Int32);
                p_rowcount.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(p_rowcount);

                cmd.ExecuteNonQuery();

                int rowsAffected = ((OracleDecimal)p_rowcount.Value).ToInt32();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên có mã: " + txtMaSV.Text);
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
                LoadData();
            }
        }


        private void ClearFields()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbGioiTinh.SelectedIndex = -1;
            cbKhoa.SelectedIndex = -1;
            txtTinhTrangHV.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu mã sinh viên nhập vào là rỗng
                if (string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã sinh viên.");
                    return;
                }

                conn.Open();
                string keyword = txtMaSV.Text;

                // Truy vấn tìm kiếm
                OracleCommand cmd = new OracleCommand("SELECT * FROM ADMIN_PJ.SINHVIEN WHERE MASV = :masv", conn);
                cmd.Parameters.Add("masv", keyword);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Kiểm tra nếu không có kết quả
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại.");
                    return;
                }

                dgvSinhVien.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvSinhVien.Rows.Add(
                        row["MASV"].ToString(),
                        row["HOTEN"].ToString(),
                        row["PHAI"].ToString(),
                        Convert.ToDateTime(row["NGSINH"]).ToString("dd/MM/yyyy"),
                        row["DCHI"].ToString(),
                        row["DT"].ToString(),
                        row["KHOA"].ToString(),
                        row["TINHTRANG"].ToString()
                    );
                }
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
