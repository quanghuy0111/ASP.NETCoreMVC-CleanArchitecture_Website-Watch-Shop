using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class HoaDonNhapDTO
    {
        public string IDHoaDonNhap { get; set; }

        public string IDNhaCungCap { get; set; }

        public float ThanhTien { get; set; }

        public DateTime NgayNhap { get; set; }
    }
}
