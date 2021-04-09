using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcDongHo.ViewModels;
using Application.DTOs;
namespace mvcDongHo.ViewModels
{
    public class TaiKhoanView
    {
     
            public TaiKhoanKHDTO TaiKhoanKHDTO { get; set; }
        //Hàm để tạo thành list kiểu ThuongHieuDTO
        public PaginatedList<TaiKhoanKHDTO> TaiKhoan { get; set; }
    }
    
}
