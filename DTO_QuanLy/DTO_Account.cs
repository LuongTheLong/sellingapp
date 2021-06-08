using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_Account
    {
        private string _TaiKhoan;
        private string _MatKhau;
        private string _MaNhanVien;

        public string TaiKhoan
        {
            get
            {
                return _TaiKhoan;
            }

            set
            {
                _TaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }

            set
            {
                _MatKhau = value;
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


        public DTO_Account()
        {

        }

        public DTO_Account(string TK, string MK, string MNV)
        {
            this.TaiKhoan = TK;
            this.MatKhau = MK;
            this.MaNhanVien = MNV;
        }
    }
}