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
    public partial class frmThongTinSV : Form
    {
        public frmThongTinSV()
        {
            InitializeComponent();
        }

        private void Load_Dulieu(object sender, EventArgs e)
        {
            dgrDSSV.DataSource = null;
            string sql1 = "SELECT * from SinhVien";
            dgrDSSV.DataSource = null;
            dgrDSSV.DataSource = KetNoi_CSDL.LoadDuLieu(sql1, "SinhVien");
            HienThi_DL();
        }



        private void bntThem_Click(object sender, EventArgs e)
        {
            {
                txtMaSV.Text = "";
                txtTenSV.Text = "";
                txtMaKhoa.Text = "";
                txtMaLop.Text = "";
                txtNgaySinh.Text = "";
                txtQueQuan.Text = "";
                txtGioiTinh.Text = "";
                txtSDT.Text = "";
                txtTinhTrang.Text = "";
            }
        }



        private void HienThi_DL()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dgrDSSV.DataSource, "MaSV");
            txtTenSV.DataBindings.Clear();
            txtTenSV.DataBindings.Add("Text", dgrDSSV.DataSource, "TenSV");
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dgrDSSV.DataSource, "MaKhoa");
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dgrDSSV.DataSource, "MaLop");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dgrDSSV.DataSource, "NgaySinh");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", dgrDSSV.DataSource, "QueQuan");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgrDSSV.DataSource, "GioiTinh");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgrDSSV.DataSource, "SDT");
            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("Text", dgrDSSV.DataSource, "TinhTrang");

        }
        private void frmThongTinSV_Load(object sender, EventArgs e)
        {
            Load_Dulieu(null, null);
            HienThi_DL();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtMaSV.Text;
                string b = txtTenSV.Text;
                string c = txtMaKhoa.Text;
                string d = txtMaLop.Text;
                string a1 = txtNgaySinh.Text;
                string a2 = txtQueQuan.Text;
                string a3 = txtGioiTinh.Text;
                string a4 = txtSDT.Text;
                string a5= txtTinhTrang.Text;
                KetNoi_CSDL.Chen_dulieu(a, b, c, d, a1, a2, a3, a4, a5);
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
            KetNoi_CSDL.LuuDL(txtMaSV.Text, txtTenSV.Text, txtMaKhoa.Text, txtMaLop.Text, txtNgaySinh.Text,txtQueQuan.Text, txtGioiTinh.Text, txtSDT.Text, txtTinhTrang.Text);
            Load_Dulieu(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.XoaDL(txtMaSV.Text);
            Load_Dulieu(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemThongTinSV fm = new frmTimKiemThongTinSV();
            fm.Show();
        }
    }
}
