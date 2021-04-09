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
    
    public class ChiTietHoaDonNhapServices : IChiTietHoaDonNhapServices
    {
        private readonly IChiTietHoaDonNhapRepository _chiTietHoaDonNhapRepository;//Tạo biến chứa dữ liệu 
        public ChiTietHoaDonNhapServices(IChiTietHoaDonNhapRepository chiTietHoaDonNhapRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _chiTietHoaDonNhapRepository = chiTietHoaDonNhapRepository;
        }
        public IEnumerable<ChiTietHoaDonNhapDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _chiTietHoaDonNhapRepository.getAll().MappingChiTietHoaDonNhapList();
        }
    }
}
