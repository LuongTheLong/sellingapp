using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_ChatLieu : DBConnect
    {
        public DataTable getChatLieu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChatLieu", _conn);
            DataTable dtChatLieu = new DataTable();
            da.Fill(dtChatLieu);
            return dtChatLieu;
        }


        public bool themChatLieu(DTO_ChatLieu cl)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO ChatLieu(MaChatLieu, TenChatLieu) VALUES ('{0}', '{1}')", cl.MaChatLieu, cl.TenChatLieu);

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

        public bool suaChatLieu(DTO_ChatLieu cl)
        {
            try
            {
                _conn.Open();

                //string SQL = string.Format("UPDATE ChatLieu SET MaChatLieu = '{0}', TenChatLieu = '{1}' WHERE MaChatLieu = '{2}'", cl.MaChatLieu, cl.TenChatLieu, macu);
                string SQL = string.Format("UPDATE ChatLieu SET TenChatLieu = '{0}' WHERE MaChatLieu = '{1}'", cl.TenChatLieu, cl.MaChatLieu);

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

        public bool xoaChatLieu(string MaChatLieu)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("DELETE FROM ChatLieu WHERE MaChatLieu = '{0}'", MaChatLieu);

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