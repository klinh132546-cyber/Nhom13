using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class ThanhToanBLL
    {
        private ThanhToanDAL dal = new ThanhToanDAL();

        public List<ThanhToan> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(ThanhToan item)
        {
            dal.Add(item);
        }

        public void Update(ThanhToan item)
        {
            dal.Update(item);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }
    }
}
