using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class PhieuXuatBLL
    {
        private PhieuXuatDAL dal = new PhieuXuatDAL();

        public List<PhieuXuat> GetAll()
        {
            return dal.GetAll();
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public List<ChiTietPhieuXuat> GetDetails(int id)
        {
            return dal.GetDetails(id);
        }

        public object GetAllDetails()
        {
            return dal.GetAllDetails();
        }

        public void Add(PhieuXuat px, List<ChiTietPhieuXuat> details)
        {
            dal.Add(px, details);
        }
    }
}
