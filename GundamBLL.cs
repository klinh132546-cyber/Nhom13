using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.BLL
{
    public class GundamBLL
    {
        private GundamDAL dal = new GundamDAL();

        public List<GundamDTO> GetAllGundams()
        {
            var data = dal.GetAllGundams();
            return data.Select(g => new GundamDTO
            {
                MaGundam = g.MaGundam,
                TenGundam = g.TenGundam,
                Gia = g.Gia,
                MaSeries = g.MaSeries,
                MaHang = g.MaHang,
                MaGrade = g.MaGrade,
                MaLoai = g.MaLoai,
                HinhAnh = g.HinhAnh,
                NgayTao = g.NgayTao,
                NgayCapNhat = g.NgayCapNhat
            }).ToList();
        }

        public GundamDTO GetById(int id)
        {
            var g = dal.GetAllGundams().FirstOrDefault(x => x.MaGundam == id);
            if (g == null) return null;
            return new GundamDTO
            {
                MaGundam = g.MaGundam,
                TenGundam = g.TenGundam,
                Gia = g.Gia,
                HinhAnh = g.HinhAnh,
                NgayTao = g.NgayTao,
                NgayCapNhat = g.NgayCapNhat
            };
        }

        public void Add(GundamDTO dto)
        {
            var g = new Gundam
            {
                TenGundam = dto.TenGundam,
                Gia = dto.Gia,
                MaSeries = dto.MaSeries,
                MaHang = dto.MaHang,
                MaGrade = dto.MaGrade,
                MaLoai = dto.MaLoai,
                HinhAnh = dto.HinhAnh,
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now
            };
            dal.Add(g);
        }

        public void Update(GundamDTO dto)
        {
            var g = new Gundam
            {
                MaGundam = dto.MaGundam,
                TenGundam = dto.TenGundam,
                Gia = dto.Gia,
                MaSeries = dto.MaSeries,
                MaHang = dto.MaHang,
                MaGrade = dto.MaGrade,
                MaLoai = dto.MaLoai,
                HinhAnh = dto.HinhAnh,
                NgayTao = dto.NgayTao,
                NgayCapNhat = DateTime.Now
            };
            dal.Update(g);
        }

        public void Delete(int id)
        {
            dal.DeleteForce(id); // Luôn sử dụng DeleteForce theo yêu cầu xóa tận gốc
        }

        public void DeleteForce(int id)
        {
            dal.DeleteForce(id);
        }

        public bool HasDependents(int id)
        {
            return dal.HasDependents(id);
        }
    }
}
