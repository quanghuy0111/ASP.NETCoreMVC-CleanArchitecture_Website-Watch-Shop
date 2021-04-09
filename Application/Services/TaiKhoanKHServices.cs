using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services
{
    
    public class TaiKhoanKHServices : ITaiKhoanKHServices
    {
        private readonly ITaiKhoanKHRepository _taiKhoanKHRepository;//Tạo biến chứa dữ liệu 
        public TaiKhoanKHServices(ITaiKhoanKHRepository taiKhoanKHRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _taiKhoanKHRepository = taiKhoanKHRepository;
        }

        public IEnumerable<TaiKhoanKHDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _taiKhoanKHRepository.getAll(pageIndex, pageSize, search, Type, out count).MappingTaiKhoanKHList();
        }
        public IEnumerable<TaiKhoanKHDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _taiKhoanKHRepository.getAll().MappingTaiKhoanKHList();
        }
        public TaiKhoanKHDTO GetTaiKhoanKH(string maTaiKhoanKH)
        {
            return _taiKhoanKHRepository.GetTaiKhoanKH(maTaiKhoanKH).MappingTaiKhoanKHDTO();

        }

        public void themTaiKhoanKH(TaiKhoanKHDTO taiKhoanKHDTO)
        {
            _taiKhoanKHRepository.ThemTaiKhoanKH(taiKhoanKHDTO.MappingTaiKhoanKH());
        }


        public void xoaTaiKhoanKH(string maTaiKhoanKH)
        {
            _taiKhoanKHRepository.XoaTaiKhoanKH(maTaiKhoanKH);
        }
        public TaiKhoanKHDTO TimTK(string TaiKhoan, string MatKhau, string IDKhachHang)
        {
            return _taiKhoanKHRepository.TimTK(TaiKhoan, MatKhau, IDKhachHang).MappingTaiKhoanKHDTO();
        }
        public void ThemTK(TaiKhoanKHDTO taiKhoanKHDTO)
        {
            _taiKhoanKHRepository.ThemTK(taiKhoanKHDTO.MappingTaiKhoanKH());
        }

        public bool login(string taiKhoan, string matKhau)
        {
            var list = _taiKhoanKHRepository.getAll();
            //var listdoi = list.MappingDTO();
            var flag = false;
            foreach (var item in list)
            {
                if (taiKhoan.Equals(item.TaiKhoan))
                {
                    if (matKhau.Equals(item.MatKhau))
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, item.TaiKhoan));

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        //_httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).Wait();
                        flag = true;
                    }
                }
            }
            return flag;
        }
    }
}
