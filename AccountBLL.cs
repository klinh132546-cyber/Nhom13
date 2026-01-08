using QuanLyBanMoHinh.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanMoHinh.BLL
{
    public class AccountBLL
    {
        AccountDAL dal = new AccountDAL();

        public Account Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            return dal.Login(username, password);
        }
    }
}
