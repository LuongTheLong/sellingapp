using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", _conn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }


        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();

                string SQL = String.Format("INSERT INTO NhanVien VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", nv.MaNhanVien, nv.TenNhanVien, nv.ChucVu, nv.GioiTinh, nv.DiaChi, nv.DienThoai, nv.NgaySinh );

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

        public bool suaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();                                                                                   

                string SQL = string.Format("UPDATE NhanVien SET TenNhanVien = '{0}', ChucVu = '{1}', GioiTinh = '{2}', DiaChi = '{3}', DienThoai = '{4}', NgaySinh = '{5}' WHERE MaNhanVien = '{6}'", nv.TenNhanVien, nv.ChucVu, nv.GioiTinh, nv.DiaChi, nv.DienThoai, nv.NgaySinh, nv.MaNhanVien);

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

        public bool xoaNhanVien(string MaNhanVien)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM NhanVien WHERE MaNhanVien = '{0}'", MaNhanVien);

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