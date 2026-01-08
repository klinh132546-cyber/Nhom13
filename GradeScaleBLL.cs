using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class GradeScaleBLL
    {
        private GradeScaleDAL dal = new GradeScaleDAL();

        public List<GradeScale> GetAll()
        {
            return dal.GetAll();
        }
    }
}
