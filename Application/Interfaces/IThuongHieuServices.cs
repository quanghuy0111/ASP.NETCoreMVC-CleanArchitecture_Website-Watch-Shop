using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IThuongHieuServices
    {
        public void themThuongHieu(ThuongHieuDTO thuongHieu);

        public void suaThuongHieu(ThuongHieuDTO thuongHieu);

        public void xoaThuongHieu(string maThuongHieu);

        public ThuongHieuDTO GetThuongHieu(string maThuongHieu);
        
        IEnumerable<ThuongHieuDTO> getAll(int pageIndex, int pageSize,string search,string Type,out int count);

        IEnumerable<ThuongHieuDTO> getAll();
    }
}
