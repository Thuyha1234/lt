using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QLSV_NHOM6
{
    class KetNoi_CSDL
    {
        public static OleDbConnection cnnQLSV;
        public static DataTable tbSV;
        private static OleDbCommand cmdSV;
        private static OleDbDataAdapter adaSV;

        public static void TaoKetNoi()
        {

            String Chuoi_Ketnoi = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                    "Data Source =" + Application.StartupPath + @"\QUANLYSV1.mdb;";

            cnnQLSV = new OleDbConnection(Chuoi_Ketnoi);
            cnnQLSV.Open();
        }

        public static void Huy_KetNoi()
        {
            cnnQLSV.Close(); 
            cnnQLSV.Dispose();
            cnnQLSV = null; 
        }

        public static DataTable Laydulieu(string sql, string TableName)
        {
            TaoKetNoi();
            DataTable ds = new DataTable();
            cmdSV = new OleDbCommand(sql, cnnQLSV);
            adaSV = new OleDbDataAdapter(cmdSV);
            adaSV.Fill(ds);
            Huy_KetNoi();
            return ds;
        }
         
        public static void Chen_dulieu(string txtMaSV, string txtTenSV, string txtMaKhoa, string txtMaLop, string txtNgaySinh, string txtQueQuan , string txtGioiTinh, string txtSDT, string txtTinhTrang  )
        {
            TaoKetNoi();
            tbSV = new DataTable("SinhVien");
            OleDbDataAdapter adaSV = new OleDbDataAdapter("SELECT * from SinhVien", cnnQLSV);
            adaSV.Fill(tbSV);
            //Insert dữ liệu vào DataTable
            DataRow R = tbSV.NewRow();
            R["MASV"] = txtMaSV;
            R["TENSV"] = txtTenSV;
            R["MAKHOA"] = txtMaKhoa;
            R["MALOP"] = txtMaLop;
            R["NGAYSINH"] = txtNgaySinh;
            R["QUEQUAN"] = txtQueQuan;
            R["GIOITINH"] = txtGioiTinh;
            R["SDT"] = txtGioiTinh;
            R["TINHTRANG"] = txtTinhTrang;
            tbSV.Rows.Add(R);
           
            OleDbCommand cmdSV = new OleDbCommand();
            cmdSV.Connection = cnnQLSV;
            cmdSV.CommandType = CommandType.Text;
            cmdSV.CommandText = "Insert into SinhVien values(@MaSV,@TenSV,@MaKhoa,@MaLop,@NgaySinh,@QueQuan,@GioiTinh,@SDT,@TinhTrang)";
            cmdSV.Parameters.Add("@MaSV", OleDbType.VarChar, 10, "MASV");
            cmdSV.Parameters.Add("@TenSV", OleDbType.VarChar, 50, "TENSV");
            cmdSV.Parameters.Add("@MaKhoa", OleDbType.VarChar, 100, "MAKHOA");
            cmdSV.Parameters.Add("@MaLop", OleDbType.VarChar, 20, "MALOP");
            cmdSV.Parameters.Add("@NgaySinh", OleDbType.VarChar, 20, "NGAYSINH");
            cmdSV.Parameters.Add("@QueQuan", OleDbType.VarChar, 20, "QUEQUAN");
            cmdSV.Parameters.Add("@GioiTinh", OleDbType.VarChar, 20, "GIOITINH");
            cmdSV.Parameters.Add("@SDT", OleDbType.VarChar, 20, "SDT");
            cmdSV.Parameters.Add("@TinhTrang", OleDbType.VarChar, 20, "TINHTRANG");
            adaSV.InsertCommand = cmdSV;
            adaSV.Update(tbSV);

            //Hủy đối tượng
            cmdSV.Dispose();
            Huy_KetNoi();
            cmdSV = null;
        }

        public static void Chen_dulieu_Khoa(string txtMaKhoa, string txtTenKhoa)
        {
            TaoKetNoi();
            tbSV = new DataTable("Khoa");
            OleDbDataAdapter adaSV = new OleDbDataAdapter("SELECT * from Khoa", cnnQLSV);
            adaSV.Fill(tbSV);
            //Insert dữ liệu vào DataTable
            DataRow R = tbSV.NewRow();
            R["MAKHOA"] = txtMaKhoa;
            R["TENKHOA"] = txtTenKhoa;
            tbSV.Rows.Add(R);
            OleDbCommand cmdSV = new OleDbCommand();
            cmdSV.Connection = cnnQLSV;
            cmdSV.CommandType = CommandType.Text;
            cmdSV.CommandText = "Insert into Khoa values(@MaKhoa,@TenKhoa)";
            cmdSV.Parameters.Add("@MaKhoa", OleDbType.VarChar, 10, "MAKHOA");
            cmdSV.Parameters.Add("@TenKhoa", OleDbType.VarChar, 50, "TENKHOA");     
            adaSV.InsertCommand = cmdSV;
            adaSV.Update(tbSV);

            //Hủy đối tượng
            cmdSV.Dispose();
            Huy_KetNoi();
            cmdSV = null;
        }

        public static void Chen_dulieu_Lop(string txtMaLop, string txtTenLop, string txtMaKhoa)
        {
            TaoKetNoi();
            tbSV = new DataTable("Lop");
            OleDbDataAdapter adaSV = new OleDbDataAdapter("SELECT * from Lop", cnnQLSV);
            adaSV.Fill(tbSV);
            DataRow R = tbSV.NewRow();
            R["MALOP"] = txtMaLop;
            R["TENLOP"] = txtTenLop;
            R["MAKHOA"] = txtMaKhoa;
            tbSV.Rows.Add(R);
            OleDbCommand cmdSV = new OleDbCommand();
            cmdSV.Connection = cnnQLSV;
            cmdSV.CommandType = CommandType.Text;
            cmdSV.CommandText = "Insert into Lop values(@MaLop,@TenLop,@MaKhoa)";
            cmdSV.Parameters.Add("@MaLop", OleDbType.VarChar, 10, "MALOP");
            cmdSV.Parameters.Add("@TenLop", OleDbType.VarChar, 50, "TENLOP");
            cmdSV.Parameters.Add("@MaKhoa", OleDbType.VarChar, 50, "MAKHOA");
            adaSV.InsertCommand = cmdSV;
            adaSV.Update(tbSV);

            //Hủy đối tượng
            cmdSV.Dispose();
            Huy_KetNoi();
            cmdSV = null;
        }

        public static void Chen_dulieu_MH(string txtMaMH, string txtTenMH, string txtSoTiet)
        {
            TaoKetNoi();
            tbSV = new DataTable("MonHoc");
            OleDbDataAdapter adaSV = new OleDbDataAdapter("SELECT * from MonHoc", cnnQLSV);
            adaSV.Fill(tbSV);
            DataRow R = tbSV.NewRow();
            R["MAMH"] = txtMaMH;
            R["TENMH"] = txtTenMH;
            R["SOTIET"] = txtSoTiet;
            tbSV.Rows.Add(R);
            OleDbCommand cmdSV = new OleDbCommand();
            cmdSV.Connection = cnnQLSV;
            cmdSV.CommandType = CommandType.Text;
            cmdSV.CommandText = "Insert into MonHoc values(@MaMH,@TenMH,@SoTiet)";
            cmdSV.Parameters.Add("@MaMH", OleDbType.VarChar, 10, "MAMH");
            cmdSV.Parameters.Add("@TenMH", OleDbType.VarChar, 50, "TENMH");
            cmdSV.Parameters.Add("@SoTiet", OleDbType.VarChar, 50, "SOTIET");
            adaSV.InsertCommand = cmdSV;
            adaSV.Update(tbSV);

            //Hủy đối tượng
            cmdSV.Dispose();
            Huy_KetNoi();
            cmdSV = null;
        }
        public static void LuuDL(string txtMaSV, string txtTenSV, string txtMaKhoa, string txtMaLop, string txtNgaySinh, string txtQueQuan, string txtGioiTinh, string txtSDT, string txtTinhTrang)
        {
            TaoKetNoi();
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnnQLSV;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update SinhVien " +
                                     "Set TENSV=@TenSV,MAKHOA=@MaKhoa,MALOP=@MaLop, NGAYSINH= @NgaySinh ,QUEQUAN=@QueQuan ,GIOITINH=@GioiTinh,SDT=@SDT,TINHTRANG=@TinhTrang " +
                                     "Where MASV=@MaSV";

            objCommand.Parameters.Add("@TenSV", OleDbType.VarChar).Value = txtTenSV;
            objCommand.Parameters.Add("@MaKhoa", OleDbType.VarChar).Value = txtMaKhoa;
            objCommand.Parameters.Add("@MaLop", OleDbType.VarChar).Value = txtMaLop;
            objCommand.Parameters.Add("@NgaySinh", OleDbType.VarChar).Value = txtNgaySinh;
            objCommand.Parameters.Add("@QueQuan", OleDbType.VarChar).Value = txtQueQuan;
            objCommand.Parameters.Add("@GioiTinh", OleDbType.VarChar).Value = txtGioiTinh;
            objCommand.Parameters.Add("@SDT", OleDbType.VarChar).Value = txtSDT;
            objCommand.Parameters.Add("@TinhTrang", OleDbType.VarChar).Value = txtTinhTrang;
            objCommand.Parameters.Add("@MaSV", OleDbType.VarChar).Value = txtMaSV;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            Huy_KetNoi();
        }

        public static void LuuDL_Khoa(string txtMaKhoa, string txtTenKhoa)
        {
            TaoKetNoi();
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnnQLSV;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update Khoa " +
                                     "Set TENKHOA=@TenKhoa " +
                                     "Where MAKHOA=@MaKhoa";

            objCommand.Parameters.Add("@TenKhoa", OleDbType.VarChar).Value = txtTenKhoa;
            objCommand.Parameters.Add("@MaKhoa", OleDbType.VarChar).Value = txtMaKhoa;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            Huy_KetNoi();
        }

        public static void LuuDL_Lop(string txtMaLop, string txtTenLop, string txtMaKhoa)
        {
            TaoKetNoi();
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnnQLSV;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update Lop " +
                                     "Set TENLOP=@TenLop,MAKHOA=@MaKhoa " +
                                     "Where MALOP=@MaLop";

            objCommand.Parameters.Add("@TenLop", OleDbType.VarChar).Value = txtTenLop;
            objCommand.Parameters.Add("@MaKhoa", OleDbType.VarChar).Value = txtMaKhoa;
            objCommand.Parameters.Add("@MaLop", OleDbType.VarChar).Value = txtMaLop;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            Huy_KetNoi();
        }

        public static void LuuDL_MH(string txtMaMH, string txtTenMH, string txtSoTiet)
        {
            TaoKetNoi();
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnnQLSV;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update MonHoc " +
                                     "Set TENMH=@TenMH,SOTIET=@SoTiet " +
                                     "Where MAMH=@MaMH";

            objCommand.Parameters.Add("@TenMH", OleDbType.VarChar).Value = txtMaMH;
            objCommand.Parameters.Add("@SoTiet", OleDbType.VarChar).Value = txtTenMH;
            objCommand.Parameters.Add("@MaMH", OleDbType.VarChar).Value = txtSoTiet;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            Huy_KetNoi();
        }
        public static void XoaDL(string txtMaSV)
        {
            //Tạo kết nối
            TaoKetNoi();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from SinhVien", cnnQLSV);
            tbSV = new DataTable();
            objAdapter.Fill(tbSV);
            //Xây dựng commandBuilder
            new OleDbCommandBuilder(objAdapter);
            //Delete Record cần delete trong datatable
            DataRow[] objRow = tbSV.Select("MaSV = '" + txtMaSV + "'");
            objRow[0].Delete();
            
            objAdapter.Update(tbSV);
            
            objAdapter.Dispose();
            objAdapter = null;
            tbSV.Dispose();
            tbSV = null;
            Huy_KetNoi();
        }

        public static void XoaDL_Khoa(string txtKhoa)
        {
            TaoKetNoi();
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Khoa", cnnQLSV);
            tbSV = new DataTable();
            objAdapter.Fill(tbSV);
            new OleDbCommandBuilder(objAdapter);
            DataRow[] objRow = tbSV.Select("MaKhoa = '" + txtKhoa + "'");
            objRow[0].Delete();
            objAdapter.Update(tbSV);
            objAdapter.Dispose();
            objAdapter = null;
            tbSV.Dispose();
            tbSV = null;
            Huy_KetNoi();
        }
        public static void XoaDL_Lop(string txtLop)
        {
            TaoKetNoi();
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from Lop", cnnQLSV);
            tbSV = new DataTable();
            objAdapter.Fill(tbSV);
            new OleDbCommandBuilder(objAdapter);
            DataRow[] objRow = tbSV.Select("MaLop = '" + txtLop + "'");
            objRow[0].Delete();
            objAdapter.Update(tbSV);
            objAdapter.Dispose();
            objAdapter = null;
            tbSV.Dispose();
            tbSV = null;
            Huy_KetNoi();
        }

        public static void XoaDL_MH(string txtMH)
        {
            TaoKetNoi();
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from MonHoc", cnnQLSV);
            tbSV = new DataTable();
            objAdapter.Fill(tbSV);
            new OleDbCommandBuilder(objAdapter);
            DataRow[] objRow = tbSV.Select("MaMH = '" + txtMH + "'");
            objRow[0].Delete();
            objAdapter.Update(tbSV);
            objAdapter.Dispose();
            objAdapter = null;
            tbSV.Dispose();
            tbSV = null;
            Huy_KetNoi();
        }
        public static DataTable LoadDuLieu(string SQL, string TableName)
        {
            TaoKetNoi();
            DataTable ds = new DataTable();
            cmdSV = new OleDbCommand(SQL, cnnQLSV);
            adaSV = new OleDbDataAdapter(cmdSV);
            adaSV.Fill(ds);
            Huy_KetNoi();
            return ds;
        }
        public static void LuuDL_User(string txtpwd, string txtmatk)
        {
            //Tạo kết nối tới file Access
            TaoKetNoi();
            //Tạo đối tượng command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnnQLSV;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update Sinhvien " +
                                     "Set MAKHOA = @PWD " +
                                     "Where MASV=@MATK";

            objCommand.Parameters.Add("@PWD", OleDbType.VarChar).Value = txtpwd;
            objCommand.Parameters.Add("@MATK", OleDbType.VarChar).Value = txtmatk;

            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            Huy_KetNoi();
        }




    }
}
