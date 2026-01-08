using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHang> GetAll()
        {
            return dal.GetAll();
        }

        public List<KhachHang> GetVIPs()
        {
            return dal.GetVIPs();
        }

        public void Add(KhachHang kh) => dal.Add(kh);
        public void Update(KhachHang kh) => dal.Update(kh);
        public void Delete(int id) => dal.Delete(id);
        public bool HasDependents(int id) => dal.HasDependents(id);
        public List<KhachHang> SearchByPhone(string phone) => dal.SearchByPhone(phone);
    }
}
