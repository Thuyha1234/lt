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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Đăng nhập với tư cách quản trị viên");
                frmMainQLSV f20 = new frmMainQLSV();
                f20.Show();
                this.Hide();
            }
            else
            {
                KetNoi_CSDL.TaoKetNoi();
                string strSql = "Select COUNT(*) from NGUOIDUNG where TENDN = @ID  and MATKHAU = @PWD";
               
                OleDbCommand cmd = new OleDbCommand(strSql, KetNoi_CSDL.cnnQLSV);
                cmd.Parameters.AddWithValue("@ID", txtUsername.Text);
                cmd.Parameters.AddWithValue("@PWD", txtPassword.Text);

                this.Hide();
   
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmSV fm = new frmSV();
                    fm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    this.Show();
                }
               // KetNoi_CSDL.Huy_KetNoi();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTrogiup show = new frmTrogiup();
            show.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmDoiMatKhau show = new frmDoiMatKhau();
            //show.Show();
        }
    }
}
