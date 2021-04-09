using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using mvcDongHo.ViewModels;
namespace mvcDongHo.ViewModels
{
    public class SanPhamView
    {
        public SanPhamDTO sanPhamDTO { get; set; }
        //Hàm để tạo thành list kiểu ThuongHieuDTO
        public PaginatedList<SanPhamDTO> SanPham { get; set; }
        //Tạo biến để lưu text search
        public string textSearch { get; set; }
        //Tạo biến để lưu loại thương hiệu
        public string type{get; set;}
        //Tạo mảng để hiện danh sách thương hiệu
        public IEnumerable<ThuongHieuDTO> ThuongHieu{get;set;}
        //Tạo biến để biết search giá thấp->cao hay cao->thấp
        public Boolean price{get;set;}
    }
}
