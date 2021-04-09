using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITaiKhoanKHRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<TaiKhoanKH> getAll(int pageIndex, int pageSize, string search, string Type, out int count);
        IEnumerable<TaiKhoanKH> getAll();
        public void ThemTaiKhoanKH(TaiKhoanKH taiKhoanKH);
        public void XoaTaiKhoanKH(string maTaiKhoanKH);
        public TaiKhoanKH GetTaiKhoanKH(string maTaiKhoanKH);
        public TaiKhoanKH TimTK(string TaiKhoan, string MatKhau, string IDKhachHang);
        public void ThemTK(TaiKhoanKH taiKhoanKH);

    }
}
