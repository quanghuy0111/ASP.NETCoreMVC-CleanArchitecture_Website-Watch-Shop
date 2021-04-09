using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcDongHo.Areas.Admin.ViewModels;
using Application.Interfaces;
using Application.DTOs;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiTaiKhoanKHController : Controller
    {
        private readonly ITaiKhoanKHServices _taiKhoanKHServices;//khai báo services

        public QuanLiTaiKhoanKHController(ITaiKhoanKHServices taiKhoanKHServices) //contructor
        {
            _taiKhoanKHServices = taiKhoanKHServices;
        }
        public IActionResult Index(int pageIndex = 1, string searchString = "", string Type = "")//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng thương hiệu
            int pageSize = 3;//Số lượng thương hiệu trong 1 trang
            var list = _taiKhoanKHServices.getAll(pageIndex, pageSize, searchString, Type, out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new TaiKhoanKHView()
            {
                TaiKhoanKH = new PaginatedList<TaiKhoanKHDTO>(list, count, pageIndex, pageSize, searchString),
                Type = Type
            };

            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
        }

        public IActionResult ThemTaiKhoanKH()
        {
            return View();
        }
        public IActionResult ThemTaiKhoanKHData(TaiKhoanKHView taiKhoanKHView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _taiKhoanKHServices.themTaiKhoanKH(taiKhoanKHView.taiKhoanKHDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemTaiKhoanKH));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemTaiKhoanKH));
        }

        public IActionResult XoaTaiKhoanKHData(string id) //truyền mã vào để xóa một đối tượng
        {
            _taiKhoanKHServices.xoaTaiKhoanKH(id);//gọi hàm xóa bên services
            return RedirectToAction("Index"); // trả về view

        }
    }
}
