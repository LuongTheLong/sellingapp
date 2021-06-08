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
    public class DAL_Hang : DBConnect
    {
        public DataTable getHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hang", _conn);
            DataTable dtHang = new DataTable();
            da.Fill(dtHang);
            return dtHang;
        }


        public bool themHang(DTO_Hang ha)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO Hang (MaHang, MaChatLieu, TenHang, SoLuong, DonGiaNhap, DonGiaBan, GhiChu) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", ha.MaHang, ha.MaChatLieu, ha.TenHang, ha.SoLuong, ha.DonGiaNhap, ha.DonGiaBan, ha.GhiChu);

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

        public bool suaHang(DTO_Hang ha)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("UPDATE Hang SET MaChatLieu = '{0}', TenHang= '{1}', SoLuong= '{2}', DonGiaNhap= '{3}', DonGiaBan= '{4}', GhiChu= '{5}' WHERE MaHang= '{6}'", ha.MaChatLieu, ha.TenHang, ha.SoLuong, ha.DonGiaNhap, ha.DonGiaBan, ha.GhiChu, ha.MaHang);

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

        public bool xoaHang(string MaHang)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM Hang WHERE MaHang = '{0}'", MaHang);

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