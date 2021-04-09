using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.DTOs;
using mvcDongHo.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace mvcDongHo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISanPhamServices _sanPhamServices;//khai báo services
        private readonly IThuongHieuServices _thuongHieuServices;//khai báo services
        private int pageSize = 9;//Số lượng thương hiệu trong 1 trang
        public HomeController(ISanPhamServices sanPhamServices,IThuongHieuServices thuongHieuServices) //contructor
        {
            _sanPhamServices = sanPhamServices;
            _thuongHieuServices=thuongHieuServices;
        }
        
        public ActionResult Index()
        {
            var list = _sanPhamServices.get4sp(12);//hàm lấy tất cả các đối tượng ở dưới database để show thông tin sản phẩm lên
            ViewBag.List = list;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult MyAccout()
        {
            return View();
        }
   
        public ActionResult Shop(int pageIndex = 1,string textSearch="",string type="",bool price=true)
        {
            int count;//Tổng số lượng thương hiệu
           
            var list = _sanPhamServices.getAll(pageIndex, pageSize,textSearch,type,price, out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new SanPhamView
            {
                SanPham = new PaginatedList<SanPhamDTO>(list, count, pageIndex, pageSize),
                textSearch=textSearch,
                type=type,
                price=price,
                ThuongHieu= _thuongHieuServices.getAll()
            };
            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
            
        }
        public ActionResult Shopdetail(string id)
        {
            ViewBag.Xemsp = _sanPhamServices.Xemsp(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }
        public ActionResult Wishlist()
        {
            return View();
        }
        // [HttpGet]
        // public JsonResult Search(string textSearch){
        //     var list=_sanPhamServices.getAll();
        //     var content = list.Where(i=>i.TenSanPham.Contains(textSearch)).ToList();
        //     return Json(content);
        // }


        //Phần giỏ hàng
        //Thêm sản phẩm vào giỏ hàng
        public IActionResult addCart(String id)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart 
            if (cart == null) //sau đó kiểm tra có tồn tại không
            {
                //Nếu bằng null thì tạo list chứa sản phẩm đầu tiên 
                var item = _sanPhamServices.Xemsp(id);
                List<CartItem> listCart = new List<CartItem>()
               {
                   new CartItem
                   {
                       sanPhamDTO = item,
                       quantityItem = 1
                   }
               };
                //Sau đó tạo session với key "cart"
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                // nếu khác null thì dùng JsonConvert.DeserializeObject chuyển đổi json về dạng list 
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = false; //biến check để kiểm tra sản phẩm vừa thêm đã có trong giỏ hàng hay chưa.
                //sau đó kiểm tra ID sản phẩm với id nếu có tồn tại trong giỏ hàng sẵn rồi thì tăng số lượng
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].sanPhamDTO.IDSanPham == id)
                    {
                        dataCart[i].quantityItem++;
                        check = true; //chuyển biến check để có tồn tại
                    }
                }
                //Nếu chưa tồn tại thì thêm mới vào và số lượng là 1
                if (!check)
                {
                    dataCart.Add(new CartItem
                    {
                        sanPhamDTO = _sanPhamServices.Xemsp(id),
                        quantityItem = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }
            //Quay lại trang index
            return RedirectToAction(nameof(Index));

        }

        //Dùng để hiển thị sản phẩm trong giỏ hàng
        public IActionResult Cart()
        {
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

        //Hàm update sản phẩm 
        [HttpPost]
        public IActionResult updateCart(String id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].sanPhamDTO.IDSanPham == id)
                        {
                            dataCart[i].quantityItem = quantity;
                        }
                    }
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }

        //Kiểm tra sản phẩm có id là ... có trong giỏ hàng hay không . nếu có thì cho nó bay màu
        public IActionResult deleteCart(String id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].sanPhamDTO.IDSanPham == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(nameof(Cart));
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
