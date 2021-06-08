using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_QuanLy
{
    public class DAL_ChangePassword
    {
        public static bool doimatkhau(string matkhaumoi, string manhanvien)
        {
            SqlConnection _conn = new SqlConnection(@"Data Source=OBITOROSSANDER;Initial Catalog=Quan_Ly_Ban_Hang;Persist Security Info=True;User ID=sa;Password=123456789");
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE Account SET MatKhau = '{0}' where MaNhanVien = '{1}'", matkhaumoi, manhanvien);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public static bool xacnhanmatkhau(string matkhaucu, string manhanvien)
        {
            SqlConnection _conn = new SqlConnection(@"Data Source=OBITOROSSANDER;Initial Catalog=Quan_Ly_Ban_Hang;Persist Security Info=True;User ID=sa;Password=123456789");
            try
            {
                _conn.Open();

                string SQL = string.Format("SELECT * FROM Account where MatKhau = '{0}' and MaNhanVien = '{1}'", matkhaucu, manhanvien);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
