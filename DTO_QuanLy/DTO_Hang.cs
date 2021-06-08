using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_Hang
    {
        private string _MaHang;
        private string _MaChatLieu;
        private string _TenHang;
        private int _SoLuong;
        private int _DonGiaNhap;
        private int _DonGiaBan;
        private string _GhiChu;

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
        public string TenHang
        {
            get
            {
                return _TenHang;
            }

            set
            {
                _TenHang = value;
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
        public int DonGiaNhap
        {
            get
            {
                return _DonGiaNhap;
            }

            set
            {
                _DonGiaNhap = value;
            }
        }
        public int DonGiaBan
        {
            get
            {
                return _DonGiaBan;
            }

            set
            {
                _DonGiaBan = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return _GhiChu;
            }

            set
            {
                _GhiChu = value;
            }
        }
        public DTO_Hang()
        {

        }
        public DTO_Hang(string MH, string MCL, string TH, int SL, int DGN, int DGB, string GC)
        {
            this.MaHang = MH;
            this.MaChatLieu = MCL;
            this.TenHang = TH;
            this.SoLuong = SL;
            this.DonGiaNhap = DGN;
            this.DonGiaBan = DGB;
            this.GhiChu = GC;
        }
    }
}
