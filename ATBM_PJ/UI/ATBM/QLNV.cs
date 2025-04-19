using System;
using System.Windows.Forms;

namespace ATBM
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Clear all fields for new entry
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Delete selected row
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Save or update employee info
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Search for employee
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage();
            f.Show();
            this.Close();
        }

        private void groupBoxThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxThongTin_Enter_1(object sender, EventArgs e)
        {

        }

        private void QLNV_Load(object sender, EventArgs e)
        {

        }
    }
}
