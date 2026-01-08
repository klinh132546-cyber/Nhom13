using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class PhieuNhapBLL
    {
        private PhieuNhapDAL dal = new PhieuNhapDAL();

        public List<PhieuNhap> GetAll()
        {
            return dal.GetAll();
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public List<ChiTietPhieuNhap> GetDetails(int id)
        {
            return dal.GetDetails(id);
        }

        public object GetAllDetails()
        {
            return dal.GetAllDetails();
        }

        public void Add(PhieuNhap pn, List<ChiTietPhieuNhap> details)
        {
            dal.Add(pn, details);
        }
    }
}
