using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;

namespace mvcDongHo.Areas.Admin.ViewModels
{
    public class HoaDonNhapView
    {
        public HoaDonNhapDTO hoaDonNhapDTO { get; set; }
        public PaginatedList<HoaDonNhapDTO> HoaDonNhap { get; set; }
        //Biến chứa text search
        public string searchString { get; set; }
        //Biến chữa loại search
        public string Type { get; set; }
        public float Tien { get; set; }
    }
}
