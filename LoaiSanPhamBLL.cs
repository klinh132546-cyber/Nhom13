using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class LoaiSanPhamBLL
    {
        private LoaiSanPhamDAL dal = new LoaiSanPhamDAL();

        public List<LoaiSanPham> GetAll()
        {
            return dal.GetAll();
        }

        public void Add(LoaiSanPham lsp)
        {
            lsp.NgayTao = DateTime.Now;
            lsp.NgayCapNhat = DateTime.Now;
            dal.Add(lsp);
        }

        public void Update(LoaiSanPham lsp)
        {
            lsp.NgayCapNhat = DateTime.Now;
            dal.Update(lsp);
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public bool HasDependents(int id)
        {
            return dal.HasDependents(id);
        }
    }
}
