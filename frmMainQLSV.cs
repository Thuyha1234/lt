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
    public partial class frmMainQLSV : Form
    {
        public frmMainQLSV()
        {
            InitializeComponent();
        }

        /*private void btnQLKHOA_Click(object sender, EventArgs e)
        {
            frmKhoa f2 = new frmKhoa();
            f2.Show();
        }*/

        /*private void btnQLLOP_Click(object sender, EventArgs e)
        {
            frmLop f3 = new frmLop();
            f3.Show();
        }*/

        /*private void btnQLMH_Click(object sender, EventArgs e)
        {
            frmMonHoc f4 = new frmMonHoc();
            f4.Show();
        }*/

        /*private void btnQLSV_Click_1(object sender, EventArgs e)
        {
            frmThongTinSV f1 = new frmThongTinSV();
            f1.Show();
        }*/

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đóng ứng dụng?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.OK:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa f8 = new frmKhoa();
            f8.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop f9 = new frmLop();
            f9.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc f10 = new frmMonHoc();
            f10.Show();
        }

        /*private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSV f11 = new frmThongTinSV();
            f11.Show();
        }*/

        /*private void tìmKiếmThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemThongTinSV f12 = new frmTimKiemThongTinSV();
            f12.Show();
        }*/

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDoiMatKhau show = new frmDoiMatKhau();
            //show.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.OK:
                    this.Close();
                    frmDangNhap show = new frmDangNhap();
                    show.Show();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeSV show = new frmThongKeSV();
            show.Show();
        }

        private void điểmTổngKếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemTK show = new frmDiemTK();
            show.Show();
        }

        private void điểmThànhPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiemTP show = new frmDiemTP();
            show.Show();
        }

        private void họcBổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocBong show = new frmHocBong();
            show.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout show = new frmAbout();
            show.Show();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThongTinSV f11 = new frmThongTinSV();
            f11.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemThongTinSV f12 = new frmTimKiemThongTinSV();
            f12.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
