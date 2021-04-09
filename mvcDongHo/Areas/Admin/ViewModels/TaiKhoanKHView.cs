using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
namespace mvcDongHo.Areas.Admin.ViewModels
{
    public class TaiKhoanKHView
    {
        public TaiKhoanKHDTO taiKhoanKHDTO { get; set; }
        //Hàm để tạo thành list kiểu TaiKhoanKHDTO
        public PaginatedList<TaiKhoanKHDTO> TaiKhoanKH { get; set; }
        //Biến chứa text search
        public string searchString { get; set; }
        //Biến chữa loại search
        public string Type { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}
