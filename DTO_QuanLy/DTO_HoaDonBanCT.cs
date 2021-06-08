using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_HoaDonBanCT
    {
        private string _MaHoaDon;
        private string _MaHang;
        private int _SoLuong;
        private int _DonGia;
        private float _GiamGia;
        private float _ThanhTien;


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

        public string MaHang
        {
            get
            {
                return _MaHang;
            }

            set
            {
                _MaHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }

        public int DonGia
        {
            get
            {
                return _DonGia;
            }

            set
            {
                _DonGia = value;
            }
        }

        public float GiamGia
        {
            get
            {
                return _GiamGia;
            }

            set
            {
                _GiamGia = value;
            }
        }

        public float ThanhTien
        {
            get
            {
                return _ThanhTien;
            }

            set
            {
                _ThanhTien = value;
            }
        }



        public DTO_HoaDonBanCT()
        {

        }

        public DTO_HoaDonBanCT(string MHD, string MH, int SL, int DG, float GG, float TT)
        {
            this.MaHoaDon = MHD;
            this.MaHang = MH;
            this.SoLuong = SL;
            this.DonGia = DG;
            this.GiamGia = GG;
            this.ThanhTien = TT;
        }
    }
}