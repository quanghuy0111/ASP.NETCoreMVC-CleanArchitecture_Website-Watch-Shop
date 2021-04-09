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
    
    public class HoaDonNhapServices : IHoaDonNhapServices
    {
        private readonly IHoaDonNhapRepository _hoaDonNhapRepository;//Tạo biến chứa dữ liệu 
        public HoaDonNhapServices(IHoaDonNhapRepository hoaDonNhapRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _hoaDonNhapRepository = hoaDonNhapRepository;
        }
        public IEnumerable<HoaDonNhapDTO> getAll(int pageIndex, int pageSize,string search,string Type,float Tien,out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _hoaDonNhapRepository.getAll(pageIndex,pageSize,search,Type,Tien,out count).MappingHoaDonNhapList();
        }
    }
}
