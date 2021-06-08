using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data;
namespace BUS_QuanLy
{
   public  class BUS_Hang
    {
        DAL_Hang dalHang = new DAL_Hang();

        public DataTable getHang()
        {
            return dalHang.getHang();
        }

        public bool themHang(DTO_Hang ha)
        {
            return dalHang.themHang(ha);
        }

        public bool suaHang(DTO_Hang ha)
        {
            return dalHang.suaHang(ha);
        }

        public bool xoaHang(string MaHang)
        {
            return dalHang.xoaHang(MaHang);
        }
    }
}