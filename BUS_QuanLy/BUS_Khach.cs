using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_Khach
    {
        DAL_Khach dalKhach = new DAL_Khach();

        public DataTable getKhach()
        {
            return dalKhach.getKhach();
        }

        public bool themKhach(DTO_Khach kh)
        {
            return dalKhach.themKhach(kh);
        }

        public bool suaKhach(DTO_Khach kh)
        {
            return dalKhach.suaKhach(kh);
        }

        public bool xoaKhach(string MaKhach)
        {
            return dalKhach.xoaKhach(MaKhach);
        }
    }
}