using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IKhachHangRepository
    {

        //Viết hàm chức năng ở đây, xem mẫu ở IKhachHangRepository.cs
        IEnumerable<KhachHang> getAll(int pageIndex, int pageSize, string search, string Type, out int count);
        IEnumerable<KhachHang> getAll();
        public void ThemKhachHang(KhachHang khachHang);
        public void SuaKhachHang(KhachHang khachHang);
        public void XoaKhachHang(string maKhachHang);

        public KhachHang GetKhachHang(string maKhachHang);
    }
}
