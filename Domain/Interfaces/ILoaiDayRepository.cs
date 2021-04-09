using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILoaiDayRepository
    {
        //Viết hàm chức năng ở đây, xem mẫu ở ISanPhamRepository.cs
        IEnumerable<LoaiDay> getAll(int pageIndex, int pageSize, string search, string Type, out int count);
        IEnumerable<LoaiDay> getAll();
        public void ThemLoaiDay(LoaiDay loaiDay);
        public void SuaLoaiDay(LoaiDay loaiDay);
        public void XoaLoaiDay(string maLoaiDay);
        public LoaiDay GetLoaiDay(string maLoaiDay);
    }
}
