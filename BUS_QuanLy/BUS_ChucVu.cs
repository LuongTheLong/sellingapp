using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;
namespace BUS_QuanLy
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dalChucVu = new DAL_ChucVu();

        public DataTable getChucVu()
        {
            return dalChucVu.getChucVu();
        }

        public bool themChucVu(DTO_ChucVu cv)
        {
            return dalChucVu.themChucVu(cv);
        }

        public bool suaChucVu(DTO_ChucVu cv)
        {
            return dalChucVu.suaChucVu(cv);
        }

        public bool xoaChucVu(string IDCV)
        {
            return dalChucVu.xoaChucVu(IDCV);
        }
    }
}