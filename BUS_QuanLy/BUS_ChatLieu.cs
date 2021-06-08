using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ChatLieu
    {
        DAL_ChatLieu dalChatLieu = new DAL_ChatLieu();

        public DataTable getChatLieu()
        {
            return dalChatLieu.getChatLieu();
        }

        public bool themChatLieu(DTO_ChatLieu cl)
        {
            return dalChatLieu.themChatLieu(cl);
        }

        public bool suaChatLieu(DTO_ChatLieu cl)
        {
            return dalChatLieu.suaChatLieu(cl);
        }

        public bool xoaChatLieu(string MaChatLieu)
        {
            return dalChatLieu.xoaChatLieu(MaChatLieu);
        }
    }
}