using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcDongHo.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")] //để nó hiểu được những class trong Admin
    public class QuanLiLoaiDayController : Controller
    {
        private readonly ILoaiDayServices _loaiDayServices;//khai báo services

        public QuanLiLoaiDayController(ILoaiDayServices loaiDayServices) //contructor
        {
            _loaiDayServices = loaiDayServices;
        }
        public IActionResult Index(int pageIndex = 1, string searchString = "", string Type = "")//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng loại dây
            int pageSize = 3;//Số lượng loại dây trong 1 trang
            var list = _loaiDayServices.getAll(pageIndex, pageSize, searchString, Type, out count);//Hàm này lấy loại dây lên theo số trang , số lượng loại dây 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new LoaiDayView()
            {
                LoaiDay = new PaginatedList<LoaiDayDTO>(list, count, pageIndex, pageSize, searchString),
                Type = Type
            };

            //Trả về view + biến indexVM đang giữ list loại dây
            return View(indexVM);
        }

        public IActionResult ThemLoaiDay()
        {
            return View();
        }
        public IActionResult ThemLoaiDayData(LoaiDayView loaiDayView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _loaiDayServices.themLoaiDay(loaiDayView.loaiDayDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemLoaiDay));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemLoaiDay));
        }

        public IActionResult SuaLoaiDayData(LoaiDayView loaiDayView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _loaiDayServices.suaLoaiDay(loaiDayView.loaiDayDTO);//gọi hàm sửa ở services
                return RedirectToAction("Index");//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaLoaiDay(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
                                                     //giao diện QuanLiLoaiDay/Index truy xuất xuống services/reponsitory để lấy đối tượng loại dây lên và gán dữ liệu cho trang SuaLoaiDay

        {
            ViewBag.SuaLoaiDay = _loaiDayServices.GetLoaiDay(id);//gọi hàm lấy một đối tượng loại dây bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaLoaiDayData(string id) //truyền mã vào để xóa một đối tượng
        {
            _loaiDayServices.xoaLoaiDay(id);//gọi hàm xóa bên services
            return RedirectToAction("Index"); // trả về view

        }
    }
}
