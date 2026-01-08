using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class ChiTietDonHangBLL
    {
        private ChiTietDonHangDAL dal = new ChiTietDonHangDAL();

        public List<ChiTietDonHang> GetAll()
        {
            return dal.GetAll();
        }

        public List<ChiTietDonHang> GetByMaDon(int id)
        {
            return dal.GetByMaDon(id);
        }
    }
}
