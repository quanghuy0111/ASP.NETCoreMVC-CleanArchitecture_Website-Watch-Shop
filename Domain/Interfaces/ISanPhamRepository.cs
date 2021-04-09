using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISanPhamRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<SanPham> getAll(int pageIndex, int pageSize, string search, string Type, out int count);
        IEnumerable<SanPham> getAll(int pageIndex, int pageSize, string textSearch, string type, bool price, out int count);
        IEnumerable<SanPham> getAll();
        public IEnumerable<SanPham> get4sp(int boqua);
        public void ThemSanPham(SanPham sanPham);
        public void SuaSanPham(SanPham sanPham);
        public void XoaSanPham(string maSanPham);
        public SanPham GetSanPham(string maSanPham);
        public SanPham Xemsp(string maSanPham);

    }
}
