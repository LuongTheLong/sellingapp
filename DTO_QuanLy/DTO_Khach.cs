using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_Khach
    {
        private string _MaKhach;
        private string _TenKhach;
        private string _DiaChi;
        private string _DienThoai;

        public string MaKhach
        {
            get
            {
                return _MaKhach;
            }

            set
            {
                _MaKhach = value;
            }
        }

        public string TenKhach
        {
            get
            {
                return _TenKhach;
            }

            set
            {
                _TenKhach = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }
        public string DienThoai
        {
            get
            {
                return _DienThoai;
            }

            set
            {
                _DienThoai = value;
            }
        }

        public DTO_Khach()
        {

        }

        public DTO_Khach(string MK, string TK, string DC, string DT)

        {
            this.MaKhach = MK;
            this.TenKhach = TK;
            this.DiaChi = DC;
            this.DienThoai = DT;
        }
    }

}
