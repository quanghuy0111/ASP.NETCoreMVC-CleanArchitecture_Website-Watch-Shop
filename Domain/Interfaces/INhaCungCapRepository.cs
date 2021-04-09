using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INhaCungCapRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<NhaCungCap> getAll(int pageIndex, int pageSize, string search, string Type, out int count);
        IEnumerable<NhaCungCap> getAll();
        public void ThemNhaCungCap(NhaCungCap nhaCungCap);
        public void SuaNhaCungCap(NhaCungCap nhaCungCap);
        public void XoaNhaCungCap(string maNhaCungCap);
        public NhaCungCap GetNhaCungCap(string maNhaCungCap);
    }
}
