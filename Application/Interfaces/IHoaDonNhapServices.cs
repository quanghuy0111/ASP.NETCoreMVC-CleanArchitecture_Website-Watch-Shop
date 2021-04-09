using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHoaDonNhapServices
    {
        IEnumerable<HoaDonNhapDTO> getAll(int pageIndex, int pageSize,string search,string Type,float Tien,out int count);
        
    }
}
