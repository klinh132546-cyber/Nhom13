using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class HangSanXuatBLL
    {
        private HangSanXuatDAL dal = new HangSanXuatDAL();

        public List<HangSanXuat> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(HangSanXuat hang) => dal.Add(hang);
        public void Update(HangSanXuat hang) => dal.Update(hang);
        public void Delete(int id) => dal.Delete(id);
        public bool HasDependents(int id) => dal.HasDependents(id);
    }
}
