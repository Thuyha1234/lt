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
    public partial class frmTimKiemThongTinSV : Form
    {
        public frmTimKiemThongTinSV()
        {
            InitializeComponent();
            KetNoi_CSDL.TaoKetNoi();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            KetNoi_CSDL.TaoKetNoi();
            dgrKetQua.DataSource = null;
            string sql1 = "Select * from SinhVien where MASV like '%" + txtTimKiemSV.Text + "%' or TENSV like '%" + txtTimKiemSV.Text + "%' or SDT like '%" + txtTimKiemSV.Text + "%'";
            //string sql1 = "Select * from User where USERNAME like '%"+txtTimKiemSV.Text+"%'";
            dgrKetQua.DataSource = KetNoi_CSDL.LoadDuLieu(sql1, "SinhVien");
        }
        
       

        
    }
}
