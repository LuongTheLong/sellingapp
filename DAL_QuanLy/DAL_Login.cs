using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_Login
    {
       
        public static string dangnhap(string txtTaiKhoan, string txtMatKhau, string cbbChucVu)
        {
            SqlConnection _conn = new SqlConnection(@"Data Source=OBITOROSSANDER;Initial Catalog=Quan_Ly_Ban_Hang;Persist Security Info=True;User ID=sa;Password=123456789");
            string MaNhanVien = "";
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Account INNER JOIN Chucvu ON Account.TaiKhoan = ChucVu.TaiKhoan WHERE TenChucVu = '" +cbbChucVu+ "' and Account.TaiKhoan = '" +txtTaiKhoan+ "' and Account.MatKhau = '" +txtMatKhau+ "'"), _conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        MaNhanVien = dr["MaNhanVien"].ToString();
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }
            return MaNhanVien;
        }
    }
}
