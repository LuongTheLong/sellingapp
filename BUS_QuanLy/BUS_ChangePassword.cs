using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
namespace BUS_QuanLy
{
    public class BUS_ChangePassword
    {
        public static bool doimatkhau(string matkhaumoi, string manhanvien)
        {
            return DAL_ChangePassword.doimatkhau(matkhaumoi, manhanvien);
        }

        public static bool xacnhanmatkhau(string matkhaucu, string manhanvien)
        {
            return DAL_ChangePassword.xacnhanmatkhau(matkhaucu, manhanvien);
        }
    }
}
