using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_ChatLieu
    {
        private string _MaChatLieu;
        private string _TenChatLieu;

        public string MaChatLieu
        {
            get
            {
                return _MaChatLieu;
            }

            set
            {
                _MaChatLieu = value;
            }
        }

        public string TenChatLieu
        {
            get
            {
                return _TenChatLieu;
            }
            set
            {
                _TenChatLieu = value;
            }
        }

        public DTO_ChatLieu()
        {

        }

        public DTO_ChatLieu(string MCL, string TCL)
        {
            this.MaChatLieu = MCL;
            this.TenChatLieu = TCL;
        }
    }
}
