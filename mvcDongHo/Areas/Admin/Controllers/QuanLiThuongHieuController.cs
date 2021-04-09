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
    public class QuanLiThuongHieuController : Controller
    {
        private readonly IThuongHieuServices _thuongHieuServices;//khai báo services

        public QuanLiThuongHieuController(IThuongHieuServices thuongHieuServices) //contructor
        {
            _thuongHieuServices = thuongHieuServices;
        }
        public IActionResult Index(int pageIndex = 1,string searchString="",string Type="" )//pageIndex được mặc định là 1 nếu không có truyền vào
        //pageIndex là trang hiện hành
        //searchString là chuỗi tìm kiếm
        //Type là loại mà chuỗi tìm kiếm muốn nhắm đến , ví dụ ID, Name,...
        {
            int count;//Tổng số lượng thương hiệu
            int pageSize = 3;//Số lượng thương hiệu trong 1 trang
            var list = _thuongHieuServices.getAll(pageIndex,pageSize,searchString,Type,out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new ThuongHieuView()
            {
                ThuongHieu = new PaginatedList<ThuongHieuDTO>(list,count, pageIndex, pageSize,searchString),
                Type=Type
            };
            
            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
        }

        public IActionResult ThemThuongHieu()
        { 
            return View();
        }
        public IActionResult ThemThuongHieuData(ThuongHieuView thuongHieuView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if(ModelState.IsValid)
            {
                _thuongHieuServices.themThuongHieu(thuongHieuView.thuongHieuDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemThuongHieu));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemThuongHieu));
        }

        public IActionResult SuaThuongHieuData(ThuongHieuView thuongHieuView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _thuongHieuServices.suaThuongHieu(thuongHieuView.thuongHieuDTO);//gọi hàm sửa ở services
                return RedirectToAction("Index");//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaThuongHieu(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
            //giao diện QuanLiThuongHieu/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaThuongHieu

        {
            ViewBag.SuaThuongHieu = _thuongHieuServices.GetThuongHieu(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }


        public IActionResult XoaThuongHieuData(string id) //truyền mã vào để xóa một đối tượng
        {
            _thuongHieuServices.xoaThuongHieu(id);//gọi hàm xóa bên services
            return RedirectToAction("Index"); // trả về view

        }
        
    }
}
