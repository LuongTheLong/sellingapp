using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_HoaDonBanCT
    {
        DAL_HoaDonBanCT dalHoaDonBanCT = new DAL_HoaDonBanCT();

        public DataTable getHoaDonBanCT()
        {
            return dalHoaDonBanCT.getHoaDonBanCT();
        }

        public bool themHoaDonBanCT(DTO_HoaDonBanCT hdbct)
        {
            return dalHoaDonBanCT.themHoaDonBanCT(hdbct);
        }

        public bool suaHoaDonBanCT(DTO_HoaDonBanCT hdbct)
        {
            return dalHoaDonBanCT.suaHoaDonBanCT(hdbct);
        }

        public bool xoaHoaDonBanCT(string MaHoaDon)
        {
            return dalHoaDonBanCT.xoaHoaDonBanCT(MaHoaDon);
        }
    }
}