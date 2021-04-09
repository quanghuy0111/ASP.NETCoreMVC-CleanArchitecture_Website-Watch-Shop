using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class HoaDonBanServices : IHoaDonBanServices
    {
        private readonly IHoaDonBanRepository _hoaDonBanRepository;//Tạo biến chứa dữ liệu 
        public HoaDonBanServices(IHoaDonBanRepository hoaDonBanRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _hoaDonBanRepository = hoaDonBanRepository;
        }
        public IEnumerable<HoaDonBanDTO> getAll(int pageIndex, int pageSize,string search,string Type,float Tien,out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _hoaDonBanRepository.getAll(pageIndex,pageSize,search,Type,Tien,out count).MappingHoaDonBanList();
        }
    }
}
