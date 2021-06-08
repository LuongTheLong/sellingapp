using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dalHoaDonBan = new DAL_HoaDonBan();

        public DataTable getHoaDonBan()
        {
            return dalHoaDonBan.getHoaDonBan();
        }

        public bool themHoaDonBan(DTO_HoaDonBan hdb)
        {
            return dalHoaDonBan.themHoaDonBan(hdb);
        }

        public bool suaHoaDonBan(DTO_HoaDonBan hdb)
        {
            return dalHoaDonBan.suaHoaDonBan(hdb);
        }

        public bool xoaHoaDonBan(string MaHoaDon)
        {
            return dalHoaDonBan.xoaHoaDonBan(MaHoaDon);
        }
    }
}