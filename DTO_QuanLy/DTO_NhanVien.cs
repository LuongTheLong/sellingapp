using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        private string _MaNhanVien;
        private string _TenNhanVien;
        private string _ChucVu;
        private string _GioiTinh;
        private string _DiaChi;
        private string _DienThoai;
        private string _NgaySinh;

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
        public string TenNhanVien
        {
            get
            {
                return _TenNhanVien;
            }

            set
            {
                _TenNhanVien = value;
            }
        }
        public string ChucVu
        {
            get
            {
                return _ChucVu;
            }

            set
            {
                _ChucVu = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
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
        public string NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string MNV, string TNV, string CV, string GT, string DC, string DT, string NS)

        {
            this.MaNhanVien = MNV;
            this.TenNhanVien = TNV;
            this.ChucVu = CV;
            this.GioiTinh = GT;
            this.DiaChi = DC;
            this.DienThoai = DT;
            this.NgaySinh = NS;
        }

    }
}
