using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class SeriesGundamBLL
    {
        private SeriesGundamDAL dal = new SeriesGundamDAL();

        public List<SeriesGundam> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(SeriesGundam series) => dal.Add(series);
        public void Update(SeriesGundam series) => dal.Update(series);
        public void Delete(int id) => dal.Delete(id);
        public bool HasDependents(int id) => dal.HasDependents(id);
    }
}
