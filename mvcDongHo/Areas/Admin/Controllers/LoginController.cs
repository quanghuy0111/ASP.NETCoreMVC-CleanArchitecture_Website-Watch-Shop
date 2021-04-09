using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using mvcDongHo.Areas.Admin.ViewModels;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public readonly ITaiKhoanKHServices _khService;
        public LoginController(ITaiKhoanKHServices khService)
        {
            _khService = khService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Entry(TaiKhoanKHView kh)
        {
            if (ModelState.IsValid)
            {
                if (_khService.login(kh.TaiKhoan, kh.MatKhau))
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                }
                else
                {
                    ViewBag.Error = "Tai khoan hoac mat khau bi sai!";
                    return View(nameof(Index));
                }
            }
            else
            {
                ViewBag.Error = "Dang nhap bi sai";
                return View(nameof(Index));
            }
        }
    }
    /*modelstate.isvalid là kiểm tra xem các các dữ liệu được post lên có đầy đủ thông tin hay không
     */
}
