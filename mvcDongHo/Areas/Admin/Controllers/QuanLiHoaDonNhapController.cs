using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcDongHo.Areas.Admin.ViewModels;
using Application.Interfaces;
using Application.DTOs;
namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiHoaDonNhapController : Controller
    {
        private readonly IHoaDonNhapServices _hoaDonNhapServices;//khai báo services,để dùng được phải khai báo scope ở startup
        private readonly IChiTietHoaDonNhapServices _chiTietHoaDonNhapServices;//khai báo services,để dùng được phải khai báo scope ở startup
        public QuanLiHoaDonNhapController(IHoaDonNhapServices hoaDonNhapServices,IChiTietHoaDonNhapServices chiTietHoaDonNhapServices) //contructor
        {
            _hoaDonNhapServices = hoaDonNhapServices;
            _chiTietHoaDonNhapServices = chiTietHoaDonNhapServices;
        }
        public IActionResult Index(int pageIndex = 1,string searchString="",string Type="" ,float Tien=0)//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng thương hiệu
            int pageSize = 3;//Số lượng thương hiệu trong 1 trang
            var list = _hoaDonNhapServices.getAll(pageIndex,pageSize,searchString,Type,Tien,out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new HoaDonNhapView()
            {
                HoaDonNhap = new PaginatedList<HoaDonNhapDTO>(list,count, pageIndex, pageSize,searchString),
            };
            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
        }
        [HttpGet]
        public JsonResult HoaDonNhap(string IDHoaDonNhap)
        {
            var chitiet=_chiTietHoaDonNhapServices.getAll();
            var list =chitiet.Where(i=>i.IDHoaDonNhap==IDHoaDonNhap).ToList();
            return Json(list);
        }
    }
}
