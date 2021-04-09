using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcDongHo.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiSanPhamController : Controller
    {
        private readonly ISanPhamServices _sanPhamServices;//khai báo services

        public QuanLiSanPhamController(ISanPhamServices sanPhamServices) //contructor
        {
            _sanPhamServices = sanPhamServices;
        }
        public IActionResult Index(int pageIndex = 1, string searchString = "", string Type = "")//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng thương hiệu
            int pageSize = 3;//Số lượng thương hiệu trong 1 trang
            var list = _sanPhamServices.getAll(pageIndex, pageSize, searchString, Type, out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new SanPhamView()
            {
                SanPham = new PaginatedList<SanPhamDTO>(list, count, pageIndex, pageSize, searchString),
                Type = Type
            };

            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
        }

        public IActionResult ThemSanPham()
        {
            return View();
        }
        public IActionResult ThemSanPhamData(SanPhamView sanPhamView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _sanPhamServices.themSanPham(sanPhamView.sanPhamDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemSanPham));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemSanPham));
        }

        public IActionResult SuaSanPhamData(SanPhamView sanPhamView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _sanPhamServices.suaSanPham(sanPhamView.sanPhamDTO);//gọi hàm sửa ở services
                return RedirectToAction("Index");//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaSanPham(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
                                                     //giao diện QuanLiSanPham/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaSanPham

        {
            ViewBag.SuaSanPham = _sanPhamServices.GetSanPham(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaSanPhamData(string id) //truyền mã vào để xóa một đối tượng
        {
            _sanPhamServices.xoaSanPham(id);//gọi hàm xóa bên services
            return RedirectToAction("Index"); // trả về view

        }
    }
}
