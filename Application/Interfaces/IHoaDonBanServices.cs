using Application.DTOs;
// using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHoaDonBanServices
    {
        IEnumerable<HoaDonBanDTO> getAll(int pageIndex, int pageSize,string search,string Type,float Tien,out int count);
    }
}
