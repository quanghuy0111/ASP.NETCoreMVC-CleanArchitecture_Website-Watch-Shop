using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.DTOs;
using mvcDongHo.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace mvcDongHo.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly ISanPhamServices _sanPhamServices;//khai báo services
        private readonly ITaiKhoanKHServices _taiKhoanKHServices;//khai báo services
        public TaiKhoanController(ITaiKhoanKHServices taiKhoanKHServices, ISanPhamServices sanPhamServices) //contructor
        {
            _taiKhoanKHServices = taiKhoanKHServices;
            _sanPhamServices = sanPhamServices;
        }
        public IActionResult Checkout()
        {
            var list = _taiKhoanKHServices.getAll();//hàm lấy tất cả các đối tượng ở dưới database để show thông tin sản phẩm lên
            ViewBag.List = list;//lưu danh sách vừa lấy được vào viewbag đê show ra bên index
            //Giỏ hàng
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart; //gán list sản phẩm trong giỏ hàng cho "cart"
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult ThemTKData(TaiKhoanView taiKhoanView)
        {
            ViewBag.Error = "1";
            if (ModelState.IsValid)
            {
                _taiKhoanKHServices.ThemTK(taiKhoanView.TaiKhoanKHDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(Checkout));
            }
            ViewBag.Error = "0";
            return View(nameof(Checkout));
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        //Dùng để hiển thị sản phẩm trong giỏ hàng
        

    }
}
