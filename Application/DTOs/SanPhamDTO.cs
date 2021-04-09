using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class SanPhamDTO
    {
        public string IDSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string IDDay { get; set; }

        public string IDThuongHieu { get; set; }

        public string IDNhaCungCap { get; set; }

        public string BaoHanh { get; set; }

        public int SoLuong { get; set; }

        public float Gia { get; set; }

        public string HinhAnh { get; set; }
    }
}
