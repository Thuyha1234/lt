using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_NHOM6
{
    public partial class frmTrogiup : Form
    {
        public frmTrogiup()
        {
            InitializeComponent();
        }

        private void btn_DangnhapLai_Click(object sender, EventArgs e)
        {
            frmDangNhap show = new frmDangNhap();
            show.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
