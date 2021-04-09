using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITaiKhoanKHServices
    {
        bool login(string taiKhoan, string matKhau);
        public void ThemTK(TaiKhoanKHDTO taiKhoanKHDTO);
        public TaiKhoanKHDTO TimTK(string TaiKhoan, string MatKhau, string IDKhachHang);
        public void themTaiKhoanKH(TaiKhoanKHDTO taiKhoanKH);

        public void xoaTaiKhoanKH(string maTaiKhoanKH);

        public TaiKhoanKHDTO GetTaiKhoanKH(string maTaiKhoanKH);

        IEnumerable<TaiKhoanKHDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count);

        IEnumerable<TaiKhoanKHDTO> getAll();
    }
}
