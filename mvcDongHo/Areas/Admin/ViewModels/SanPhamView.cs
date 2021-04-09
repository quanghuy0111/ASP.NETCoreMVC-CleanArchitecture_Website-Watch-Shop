using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.ViewModels
{
    public class SanPhamView
    {
        public SanPhamDTO sanPhamDTO { get; set; }
        //Hàm để tạo thành list kiểu SanPhamKHDTO
        public PaginatedList<SanPhamDTO> SanPham{ get; set; }
        //Biến chứa text search
        public string searchString { get; set; }
        //Biến chữa loại search
        public string Type { get; set; }
    }
}
