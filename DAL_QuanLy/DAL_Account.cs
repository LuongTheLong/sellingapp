using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_Account : DBConnect
    {
        public DataTable getAccount()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Account", _conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            return dtAccount;
        }


        public bool themAccount(DTO_Account ac)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO Account(TaiKhoan, MatKhau,MaNhanVien) VALUES ('{0}', '{1}','{2}')", ac.TaiKhoan, ac.MatKhau, ac.MaNhanVien);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool suaAccount(DTO_Account ac)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE Account SET TaiKhoan = '{0}', MatKhau = '{1}', MaNhanVien = '{2}'", ac.TaiKhoan, ac.MatKhau, ac.MaNhanVien);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool xoaAccount(string MaNhanVien)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM Account WHERE MaNhanVien = '{0}'", MaNhanVien);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
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