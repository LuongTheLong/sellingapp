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
    public class BUS_Account
    {
        DAL_Account dalAccount = new DAL_Account();

        public DataTable getAccount()
        {
            return dalAccount.getAccount();
        }

        public bool themAccount(DTO_Account ac)
        {
            return dalAccount.themAccount(ac);
        }

        public bool suaAccount(DTO_Account ac)
        {
            return dalAccount.suaAccount(ac);
        }

        public bool xoaAccount(string TaiKhoan)
        {
            return dalAccount.xoaAccount(TaiKhoan);
        }
    }
}