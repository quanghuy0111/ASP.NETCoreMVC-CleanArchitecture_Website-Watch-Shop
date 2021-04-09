using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;

namespace mvcDongHo.Areas.Admin.ViewModels
{
    public class LoaiDayView
    {
        public LoaiDayDTO loaiDayDTO { get; set; }
        //Hàm để tạo thành list kiểu LoaiDayDTO
        public PaginatedList<LoaiDayDTO> LoaiDay { get; set; }
        //Biến chứa text search
        public string searchString { get; set; }
        //Biến chữa loại search
        public string Type { get; set; }
    }
}
