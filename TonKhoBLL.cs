using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class TonKhoBLL
    {
        private TonKhoDAL dal = new TonKhoDAL();

        public List<TonKho> GetAll()
        {
            return dal.GetAll();
        }

        public void Update(TonKho tk)
        {
            dal.Update(tk);
        }
    }
}
