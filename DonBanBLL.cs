using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class DonBanBLL
    {
        private DonBanDAL dal = new DonBanDAL();

        public List<DonBan> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(DonBan don, List<ChiTietDonHang> details)
        {
            dal.Add(don, details);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }
    }
}
