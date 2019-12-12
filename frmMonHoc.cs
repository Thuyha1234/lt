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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void Load_Dulieu(object sender, EventArgs e)
        {
            dgrMH.DataSource = null;
            string sql1 = "SELECT * from MonHoc";
            dgrMH.DataSource = null;
            dgrMH.DataSource = KetNoi_CSDL.LoadDuLieu(sql1, "MonHoc");
            HienThi_DL();
        }

        private void HienThi_DL()
        {
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", dgrMH.DataSource, "MaMH");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", dgrMH.DataSource, "TenMH");
            txtSoTiet.DataBindings.Clear();
            txtSoTiet.DataBindings.Add("Text", dgrMH.DataSource, "SoTiet");

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            Load_Dulieu(null, null);
            HienThi_DL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                txtMaMH.Text = "";
                txtTenMH.Text = "";
                txtSoTiet.Text = "";
            }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtMaMH.Text;
                string b = txtTenMH.Text;
                string c = txtSoTiet.Text;
                KetNoi_CSDL.Chen_dulieu_MH(a, b, c);
                Load_Dulieu(null, null);
            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            KetNoi_CSDL.LuuDL_MH(txtMaMH.Text, txtTenMH.Text, txtSoTiet.Text);
            Load_Dulieu(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.XoaDL_MH(txtMaMH.Text);
            Load_Dulieu(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.TaoKetNoi();
            dgrMH.DataSource = null;
            string sql5 = "Select * from MonHoc where MAMH like '%" + txtTimMH.Text + "%' or TENMH like '%" + txtTimMH.Text + "%' or SOTIET like '%" + txtTimMH.Text + "%'";
            dgrMH.DataSource = KetNoi_CSDL.LoadDuLieu(sql5, "MonHoc");
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            KetNoi_CSDL.TaoKetNoi();
            dgrMH.DataSource = null;
            string sql5 = "Select * from MonHoc where MAMH like '%" + txtTimMH.Text + "%' or TENMH like '%" + txtTimMH.Text + "%' or SOTIET like '%" + txtTimMH.Text + "%'";
            dgrMH.DataSource = KetNoi_CSDL.LoadDuLieu(sql5, "MonHoc");
        }

        private void btnThoat1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
