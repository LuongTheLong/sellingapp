using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_Khach : DBConnect
    {
        public DataTable getKhach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khach", _conn);
            DataTable dtKhach = new DataTable();
            da.Fill(dtKhach);
            return dtKhach;
        }


        public bool themKhach(DTO_Khach kh)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO Khach(MaKhach, TenKhach, DiaChi, DienThoai) VALUES ('{0}', '{1}', '{2}', '{3}')", kh.MaKhach, kh.TenKhach, kh.DiaChi, kh.DienThoai);

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

        public bool suaKhach(DTO_Khach kh)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE Khach SET TenKhach = '{0}', DiaChi = '{1}', DienTHoai = '{2}'WHERE MaKhach = '{3}'", kh.TenKhach, kh.DiaChi, kh.DienThoai, kh.MaKhach);

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

        public bool xoaKhach(string MaKhach)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM Khach WHERE MaKhach = '{0}'", MaKhach);

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