using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_HoaDonBan : DBConnect
    {
        public DataTable getHoaDonBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDonBan", _conn);
            DataTable dtHoaDonBan = new DataTable();
            da.Fill(dtHoaDonBan);
            return dtHoaDonBan;
        }


        public bool themHoaDonBan(DTO_HoaDonBan hdb)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO HoaDonBan(MaHoaDon, MaNhanVien, NgayBan, MaKhach) VALUES ('{0}', '{1}', '{2}', '{3}')", hdb.MaHoaDon, hdb.MaNhanVien, hdb.NgayBan, hdb.MaKhach);

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

        public bool suaHoaDonBan(DTO_HoaDonBan hdb)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE HoaDonBan SET MaNhanVien = '{0}', NgayBan = '{1}', MaKhach = '{2}' WHERE MaHoaDon = '{3}'", hdb.MaNhanVien, hdb.NgayBan, hdb.MaKhach, hdb.MaHoaDon);

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

        public bool xoaHoaDonBan(string MaHoaDon)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM HoaDonBan WHERE MaHoaDon = '{0}'", MaHoaDon);

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