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
    public class DAL_ChucVu : DBConnect
    {
        public DataTable getChucVu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", _conn);
            DataTable dtChucVu = new DataTable();
            da.Fill(dtChucVu);
            return dtChucVu;
        }


        public bool themChucVu(DTO_ChucVu cv)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO ChucVu(IDCV, TenChucVu,TaiKhoan) VALUES ('{0}', '{1}','{2}')", cv.IDCV, cv.TenChucVu, cv.TaiKhoan);

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

        public bool suaChucVu(DTO_ChucVu cv)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE ChucVu SET IDCV = '{0}', TenChucVu = '{1}',TaiKhoan = '{2}'", cv.IDCV, cv.TenChucVu, cv.TaiKhoan);

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

        public bool xoaChucVu(string IDCV)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM ChucVu WHERE IDCV = '{0}'", IDCV);

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