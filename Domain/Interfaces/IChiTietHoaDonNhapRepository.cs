using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IChiTietHoaDonNhapRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<ChiTietHoaDonNhap> getAll();
    }
}
