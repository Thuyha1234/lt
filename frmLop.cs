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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void Load_Dulieu(object sender, EventArgs e)
        {
            dgrLop.DataSource = null;
            string sql1 = "SELECT * from Lop";
            dgrLop.DataSource = null;
            dgrLop.DataSource = KetNoi_CSDL.LoadDuLieu(sql1, "Lop");
            HienThi_DL();
        }
        private void HienThi_DL()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dgrLop.DataSource, "MaLop");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dgrLop.DataSource, "TenLop");
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dgrLop.DataSource, "MaKhoa");

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                txtMaLop.Text = "";
                txtTenLop.Text = "";
                txtMaKhoa.Text = "";
            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            Load_Dulieu(null, null);
            HienThi_DL();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtMaLop.Text;
                string b = txtTenLop.Text;
                string c = txtMaKhoa.Text;
                KetNoi_CSDL.Chen_dulieu_Lop(a, b, c);
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
            KetNoi_CSDL.LuuDL_Lop(txtMaLop.Text, txtTenLop.Text, txtMaKhoa.Text);
            Load_Dulieu(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.XoaDL_Lop(txtMaLop.Text);
            Load_Dulieu(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.TaoKetNoi();
            dgrLop.DataSource = null;
            string sql4 = "Select * from Lop where MALOP like '%" + txtTimLop.Text + "%' or TENLOP like '%" + txtTimLop.Text + "%'";
            dgrLop.DataSource = KetNoi_CSDL.LoadDuLieu(sql4, "Lop");
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
