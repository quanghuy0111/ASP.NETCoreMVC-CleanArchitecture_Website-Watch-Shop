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
    [Area("Admin")]
    public class QuanLiNhaCungCapController : Controller
    {
        private readonly INhaCungCapServices _nhaCungCapServices;//khai báo services

        public QuanLiNhaCungCapController(INhaCungCapServices nhaCungCapServices) //contructor
        {
            _nhaCungCapServices = nhaCungCapServices;
        }
        public IActionResult Index(int pageIndex = 1,string searchString="",string Type="" )//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng nhà cung cấp
            int pageSize = 3;//Số lượng nhà cung cấp trong 1 trang
            var list = _nhaCungCapServices.getAll(pageIndex,pageSize,searchString,Type,out count);//Hàm này lấy nhà cung cấp lên theo số trang , số lượng nhà cung cấp 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new NhaCungCapView()
            {
                NhaCungCap = new PaginatedList<NhaCungCapDTO>(list,count, pageIndex, pageSize,searchString),
                Type=Type
            };
            
            //Trả về view + biến indexVM đang giữ list nhà cung cấp
            return View(indexVM);
        }

        public IActionResult ThemNhaCungCap()
        { 
            return View();
        }
        public IActionResult ThemNhaCungCapData(NhaCungCapView nhaCungCapView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if(ModelState.IsValid)
            {
                _nhaCungCapServices.themNhaCungCap(nhaCungCapView.nhaCungCapDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemNhaCungCap));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemNhaCungCap));
        }

        public IActionResult SuaNhaCungCapData(NhaCungCapView nhaCungCapView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _nhaCungCapServices.suaNhaCungCap(nhaCungCapView.nhaCungCapDTO);//gọi hàm sửa ở services
                return RedirectToAction("Index");//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaNhaCungCap(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
            //giao diện QuanLiNhaCungCap/Index truy xuất xuống services/reponsitory để lấy đối tượng nhà cung cấp lên và gán dữ liệu cho trang SuaNhaCungCap

        {
            ViewBag.SuaNhaCungCap = _nhaCungCapServices.GetNhaCungCap(id);//gọi hàm lấy một đối tượng nhà cung cấp bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaNhaCungCapData(string id) //truyền mã vào để xóa một đối tượng
        {
            _nhaCungCapServices.xoaNhaCungCap(id);//gọi hàm xóa bên services
            return RedirectToAction("Index"); // trả về view

        }
    }
}
