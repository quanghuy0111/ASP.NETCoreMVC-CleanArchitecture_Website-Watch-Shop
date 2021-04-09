using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IThuongHieuRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<ThuongHieu> getAll(int pageIndex, int pageSize,string search,string Type, out int count);
        IEnumerable<ThuongHieu> getAll();
        public void ThemThuongHieu(ThuongHieu thuongHieu);
        public void SuaThuongHieu(ThuongHieu thuongHieu);
        public void XoaThuongHieu(string maThuongHieu);
        public ThuongHieu GetThuongHieu(string maThuongHieu);

    }
}
