using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;


namespace QLSV_NHOM6
{
    public partial class frmDoiMatKhau : Form
    {
         //KNDoiMatKhau kl = new KNDoiMatKhau();
        private OleDbConnection con = null;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string select = "SELECT * FROM NguoiDung WHERE TenDN='" + txtTDN.Text + "' and MATKHAU='" + txtMK.Text + "'";
            string select = "SELECT * FROM NGUOIDUNG WHERE TENDN='" + txtTDN.Text + "' and MATKHAU='" + txtMK.Text + "'";

            OleDbCommand cmdSV = new OleDbCommand(select, con);
            OleDbDataReader reader;
            reader = cmdSV.ExecuteReader();

           // errPro1.Clear();
            if (txtTDN.Text == "")
            {
                //errPro1.SetError(txtTDN, "Tên tài khoản không được để trống!");
                txtTDN.Focus();
            }
            else if (txtMK.Text == "")
            {
                //errPro1.SetError(txtMK, "Vui lòng nhập mật khẩu!");
                txtMK.Focus();
            }
            else if (txtMKM.Text == "")
            {
                //errPro1.SetError(txtMKM, "Vui lòng nhập mật khẩu mới!");
                txtMKM.Focus();
            }
            else if (txtXNMK.Text == "")
            {
               // errPro1.SetError(txtXNMK, "Vui lòng xác nhận mật khẩu!");
                txtXNMK.Focus();
            }
            else if (txtXNMK.Text != txtMKM.Text)
            {
                MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (reader.Read())
            {
                cmdSV.Dispose();
                reader.Dispose();
                string update = "update Sinhvien set MALOP ='" + txtMKM.Text +
                    "' where MASV ='" + txtTDN.Text + "'";
                OleDbCommand cmd = new OleDbCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                cmd.Dispose();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTDN.Focus();
            }
            cmdSV.Dispose();
            reader.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.OK:
                    this.Close();
                    frmDiemTP f = new frmDiemTP();
                    f.Show();
                    // cmdSV.Dispose();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            //con = kl.Connected();
        }
    }
}
