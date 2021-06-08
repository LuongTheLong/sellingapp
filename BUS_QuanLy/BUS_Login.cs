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
    public class BUS_Login
    {
        
        public static string dangnhap(string txtTaiKhoan, string txtMatKhau, string cbbChucVu)
        {
            return DAL_Login.dangnhap(txtTaiKhoan, txtMatKhau, cbbChucVu);
        }
    }
}
