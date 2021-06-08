using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_HoaDonBanCT : DBConnect
    {
        public DataTable getHoaDonBanCT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDonBanCT", _conn);
            DataTable dtHoaDonBanCT = new DataTable();
            da.Fill(dtHoaDonBanCT);
            return dtHoaDonBanCT;
        }


        public bool themHoaDonBanCT(DTO_HoaDonBanCT hdbct)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO HoaDonBanCT(MaHoaDon, MaHang, SoLuong, DonGia, GiamGia, ThanhTien) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", hdbct.MaHoaDon, hdbct.MaHang, hdbct.SoLuong, hdbct.DonGia, hdbct.GiamGia, hdbct.ThanhTien);
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

        public bool suaHoaDonBanCT(DTO_HoaDonBanCT hdbct)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE HoaDonBanCT SET MaHang = '{0}', SoLuong = '{1}', DonGia = '{2}', GiamGia = '{3}', ThanhTien = '{4}' WHERE MaHoaDon = '{5}'", hdbct.MaHang, hdbct.SoLuong, hdbct.DonGia, hdbct.GiamGia, hdbct.ThanhTien, hdbct.MaHoaDon);

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

        public bool xoaHoaDonBanCT(string MaHoaDon)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM HoaDonBanCT WHERE MaHoaDon = '{0}'", MaHoaDon);

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