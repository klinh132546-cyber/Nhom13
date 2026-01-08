using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanMoHinh.BLL
{
    public class GundamDTO
    {
        public int MaGundam { get; set; }
        public string TenGundam { get; set; }
        public decimal? Gia { get; set; }
        public int? MaSeries { get; set; }
        public int? MaHang { get; set; }
        public int? MaGrade { get; set; }
        public int? MaLoai { get; set; }
        public string HinhAnh { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
