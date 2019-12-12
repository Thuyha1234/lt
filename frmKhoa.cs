using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLSV_NHOM6
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void Load_Dulieu(object sender, EventArgs e)
        {
            dgrKhoa.DataSource = null;
            string sql1 = "SELECT * from Khoa";
            dgrKhoa.DataSource = null;
            dgrKhoa.DataSource = KetNoi_CSDL.LoadDuLieu(sql1, "Khoa");
            HienThi_DL();
        }

        private void HienThi_DL()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dgrKhoa.DataSource, "MaKhoa");
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dgrKhoa.DataSource, "TenKhoa");

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
            }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtMaKhoa.Text;
                string b = txtTenKhoa.Text;
                KetNoi_CSDL.Chen_dulieu_Khoa(a, b);
                Load_Dulieu(null, null);
            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);

            }
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            Load_Dulieu(null, null);
            HienThi_DL();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.LuuDL_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
            Load_Dulieu(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.XoaDL_Khoa(txtMaKhoa.Text);
            Load_Dulieu(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.TaoKetNoi();
            dgrKhoa.DataSource = null;
            string sql6 = "Select * from Khoa where MAKHOA like '%" + txtTimKhoa.Text + "%' or TENKHOA like '%" + txtTimKhoa.Text + "%'";
            dgrKhoa.DataSource = KetNoi_CSDL.LoadDuLieu(sql6, "Khoa");
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
