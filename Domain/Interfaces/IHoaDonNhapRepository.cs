using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IHoaDonNhapRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<HoaDonNhap> getAll(int pageIndex, int pageSize,string search,string Type,float Tien, out int count);
    }
}
