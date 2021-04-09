using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;

namespace mvcDongHo.Areas.Admin.ViewModels
{
    public class NhaCungCapView
    {
        public NhaCungCapDTO nhaCungCapDTO { get; set; }
        //Hàm để tạo thành list kiểu NhaCungCapDTO
        public PaginatedList<NhaCungCapDTO> NhaCungCap { get; set; }
        //Biến chứa text search
        public string searchString { get; set; }
        //Biến chữa loại search
        public string Type { get; set; }
    }
}
