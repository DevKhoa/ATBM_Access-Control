using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM
{
    public partial class QLNV : Form
    {
        private string currentUser = string.Empty;

        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT SYS_CONTEXT('USERENV','SESSION_USER') FROM DUAL";
                    currentUser = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                }
                conn.Close();
            }
            LoadData();
        }

        private void LoadData()
        {
            string filterSql = txtMaNV.Text; // Lấy mã nhân viên từ TextBox nhập tìm kiếm

            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "BEGIN ADMIN_PJ.PRC_SEARCH_NHANVIEN(:p_cursor, :p_manv); END;";

                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Nếu người dùng nhập mã nhân viên thì truyền vào, không thì truyền NULL
                    if (!string.IsNullOrEmpty(filterSql))
                        cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = filterSql;
                    else
                        cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = DBNull.Value;

                    var adapter = new OracleDataAdapter((OracleCommand)cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvNhanVien.DataSource = table;

                    // Tự động hiển thị dòng đầu nếu có
                    if (table.Rows.Count > 0)
                    {
                        FillFormWithRow(table.Rows[0], table.Columns);
                    }

                    // Gắn lại sự kiện chọn dòng
                    dgvNhanVien.SelectionChanged -= dgvNhanVien_SelectionChanged;
                    dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
                }
                conn.Close();
            }
        }



        // Hàm fill dữ liệu từ dòng DataRow vào form
        private void FillFormWithRow(DataRow row, DataColumnCollection columns)
        {
            txtMaNV.Text = columns.Contains("MANV") ? row["MANV"].ToString() : "";
            txtHoTen.Text = columns.Contains("HOTEN") ? row["HOTEN"].ToString() : "";
            cbGioiTinh.SelectedItem = columns.Contains("PHAI") ? row["PHAI"].ToString() : null;

            if (columns.Contains("NGSINH") && DateTime.TryParse(row["NGSINH"].ToString(), out DateTime ngsinh))
                dtpNgaySinh.Value = ngsinh;
            else
                dtpNgaySinh.Value = DateTime.Now;

            txtLuong.Text = columns.Contains("LUONG") ? row["LUONG"].ToString() : "";
            txtPhuCap.Text = columns.Contains("PHUCAP") ? row["PHUCAP"].ToString() : "";
            txtDT.Text = columns.Contains("DT") ? row["DT"].ToString() : "";
            txtVaiTro.Text = columns.Contains("VAITRO") ? row["VAITRO"].ToString() : "";
            txtMaDV.Text = columns.Contains("MADV") ? row["MADV"].ToString() : "";
        }

        // Sự kiện chọn dòng trong DataGridView
        private void dgvNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            var currentRow = dgvNhanVien.CurrentRow;

            if (currentRow != null && currentRow.Index >= 0)
            {
                if (currentRow.DataBoundItem is DataRowView drv)
                {
                    var table = drv.DataView?.Table;
                    if (table != null)
                    {
                        FillFormWithRow(drv.Row, table.Columns);
                    }
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "BEGIN ADMIN_PJ.PRC_INSERT_NHANVIEN(:p_manv, :p_hotennv, :p_phai, :p_ngsinh, :p_luong, :p_phucap, :p_dt, :p_vaitro, :p_madv); END;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = txtMaNV.Text.Trim();
                    cmd.Parameters.Add("p_hotennv", OracleDbType.NVarchar2).Value = txtHoTen.Text.Trim();
                    cmd.Parameters.Add("p_phai", OracleDbType.NVarchar2).Value = cbGioiTinh.SelectedItem?.ToString() ?? string.Empty;
                    cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = dtpNgaySinh.Value;
                    cmd.Parameters.Add("p_luong", OracleDbType.Decimal).Value = Decimal.Parse(txtLuong.Text);
                    cmd.Parameters.Add("p_phucap", OracleDbType.Decimal).Value = Decimal.Parse(txtPhuCap.Text);
                    cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = txtDT.Text.Trim();
                    cmd.Parameters.Add("p_vaitro", OracleDbType.Varchar2).Value = txtVaiTro.Text.Trim();
                    cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value = txtMaDV.Text.Trim();

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString() ?? string.Empty;

            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "BEGIN ADMIN_PJ.PRC_DELETE_NHANVIEN(:p_manv); END;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = manv;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            string manv = dgvNhanVien.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(manv))
            {
                MessageBox.Show("Không tìm thấy mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các điều khiển trong groupBoxThongTin
            string currentPhone = txtDT.Text.Trim(); // Số điện thoại mới
            string currentHoten = txtHoTen.Text.Trim(); // Họ tên
            string currentGioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? string.Empty; // Giới tính
            DateTime currentNgaySinh = dtpNgaySinh.Value; // Ngày sinh
            decimal currentLuong = Decimal.Parse(txtLuong.Text); // Lương
            decimal currentPhuCap = Decimal.Parse(txtPhuCap.Text); // Phụ cấp
            string currentVaiTro = txtVaiTro.Text.Trim(); // Vai trò
            string currentMaDV = txtMaDV.Text.Trim(); // Mã đơn vị

            // Kiểm tra nếu có thay đổi
            string oldPhone = string.Empty;
            string oldHoten = string.Empty;

            if (dgvNhanVien.CurrentRow != null)
            {
                object? phoneObj = dgvNhanVien.CurrentRow.Cells["DT"]?.Value;
                object? hotenObj = dgvNhanVien.CurrentRow.Cells["HoTen"]?.Value;

                oldPhone = phoneObj?.ToString()?.Trim() ?? string.Empty;
                oldHoten = hotenObj?.ToString()?.Trim() ?? string.Empty;
            }

            string oldGioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? string.Empty; // Lấy giá trị trực tiếp từ ComboBox

            bool isPhoneChanged = currentPhone != oldPhone;
            bool isOtherInfoChanged = currentHoten != oldHoten || currentGioiTinh != oldGioiTinh;

            using (var conn = OracleHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    if (isPhoneChanged && !isOtherInfoChanged)
                    {
                        // Nếu chỉ thay đổi số điện thoại
                        cmd.CommandText = "BEGIN ADMIN_PJ.PRC_UPDATE_PHONE(:p_manv, :p_dt); END;";
                        cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = manv;
                        cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = currentPhone;
                    }
                    else if (isOtherInfoChanged)
                    {
                        // Nếu có thay đổi thông tin khác ngoài số điện thoại
                        cmd.CommandText = "BEGIN ADMIN_PJ.PRC_UPDATE_NHANVIEN(:p_manv, :p_hotennv, :p_phai, :p_ngsinh, :p_luong, :p_phucap, :p_dt, :p_vaitro, :p_madv); END;";
                        cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = manv;
                        cmd.Parameters.Add("p_hotennv", OracleDbType.NVarchar2).Value = currentHoten;
                        cmd.Parameters.Add("p_phai", OracleDbType.NVarchar2).Value = currentGioiTinh;
                        cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = currentNgaySinh;
                        cmd.Parameters.Add("p_luong", OracleDbType.Decimal).Value = currentLuong;
                        cmd.Parameters.Add("p_phucap", OracleDbType.Decimal).Value = currentPhuCap;
                        cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = currentPhone;
                        cmd.Parameters.Add("p_vaitro", OracleDbType.Varchar2).Value = currentVaiTro;
                        cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value = currentMaDV;
                    }

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
            LoadData();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }
    }
}
