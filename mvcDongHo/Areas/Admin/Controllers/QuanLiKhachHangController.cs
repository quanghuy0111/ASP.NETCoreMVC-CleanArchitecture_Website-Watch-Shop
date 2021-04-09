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
    [Area("Admin")] //để nó hiểu được những class trong Admin
    public class QuanLiKhachHangController : Controller
    {
        private readonly IKhachHangServices _khachHangServices;//khai báo services

        public QuanLiKhachHangController(IKhachHangServices khachHangServices) //contructor
        {
            _khachHangServices = khachHangServices;
        }
        public IActionResult Index(int pageIndex = 1, string searchString = "", string Type = "")//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng thương hiệu
            int pageSize = 3;//Số lượng thương hiệu trong 1 trang
            var list = _khachHangServices.getAll(pageIndex, pageSize, searchString, Type, out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new KhachHangView()
            {
                KhachHang = new PaginatedList<KhachHangDTO>(list, count, pageIndex, pageSize, searchString),
                Type = Type
            };

            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
        }

        public IActionResult ThemKhachHang()
        {
            return View();
        }
        public IActionResult ThemKhachHangData(KhachHangView khachHangView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _khachHangServices.themKhachHang(khachHangView.khachHangDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemKhachHang));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemKhachHang));
        }

        public IActionResult SuaKhachHangData(KhachHangView khachHangView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _khachHangServices.suaKhachHang(khachHangView.khachHangDTO);//gọi hàm sửa ở services
                return RedirectToAction("Index");//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaKhachHang(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
                                                     //giao diện QuanLiKhachHang/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaKhachHang

        {
            ViewBag.SuaKhachHang = _khachHangServices.GetKhachHang(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaKhachHangData(string id) //truyền mã vào để xóa một đối tượng
        {
            _khachHangServices.xoaKhachHang(id);//gọi hàm xóa bên services
            return RedirectToAction("Index"); // trả về view

        }

    }
}
