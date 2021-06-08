using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_ChucVu
    {
        private String _IDCV;
        private string _TenChucVu;
        private string _TaiKhoan;


        public String IDCV
        {
            get
            {
                return _IDCV;
            }

            set
            {
                _IDCV = value;
            }
        }

        public string TenChucVu
        {
            get
            {
                return _TenChucVu;
            }

            set
            {
                _TenChucVu = value;
            }
        }

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


        public DTO_ChucVu()
        {

        }

        public DTO_ChucVu(string IDCV, string TCV, string TK)
        {
            this.IDCV = IDCV;
            this.TenChucVu = TCV;
            this.TaiKhoan = TK;
        }
    }
}