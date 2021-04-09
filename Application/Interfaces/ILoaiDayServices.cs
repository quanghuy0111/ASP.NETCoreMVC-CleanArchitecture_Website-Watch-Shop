using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILoaiDayServices
    {
        public void themLoaiDay(LoaiDayDTO loaiDay);

        public void suaLoaiDay(LoaiDayDTO loaiDay);

        public void xoaLoaiDay(string maLoaiDay);

        public LoaiDayDTO GetLoaiDay(string maLoaiDay);

        IEnumerable<LoaiDayDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count);

        IEnumerable<LoaiDayDTO> getAll();
    }
}
