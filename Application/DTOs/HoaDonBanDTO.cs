using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class HoaDonBanDTO
    {
        public string IDHoaDonBan { get; set; }

        public string IDKhachHang { get; set; }

        public float ThanhTien { get; set; }

        public DateTime NgayBan { get; set; }

        public string TrangThai { get; set; }
    }
}
