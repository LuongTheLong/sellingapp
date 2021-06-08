using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_HoaDonBan
    {
        private string _MaHoaDon;
        private string _MaNhanVien;
        private string _NgayBan;
        private string _MaKhach;


        public string MaHoaDon
        {
            get
            {
                return _MaHoaDon;
            }

            set
            {
                _MaHoaDon = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }

            set
            {
                _MaNhanVien = value;
            }
        }

        public string NgayBan
        {
            get
            {
                return _NgayBan;
            }

            set
            {
                _NgayBan = value;
            }
        }

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



        public DTO_HoaDonBan()
        {

        }

        public DTO_HoaDonBan(string MHD, string MNV, string NB, string MK)
        {
            this.MaHoaDon = MHD;
            this.MaNhanVien = MNV;
            this.NgayBan = NB;
            this.MaKhach = MK;
        }
    }
}