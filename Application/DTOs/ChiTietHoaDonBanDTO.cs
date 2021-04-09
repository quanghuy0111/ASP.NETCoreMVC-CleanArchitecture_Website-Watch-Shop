using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ChiTietHoaDonBanDTO
    {
        public int IDChiTietHoaDonBan { get; set; }

        public string IDHoaDon { get; set; }

        public string IDSanPham { get; set; }

        public int SoLuong { get; set; }
    }
}
