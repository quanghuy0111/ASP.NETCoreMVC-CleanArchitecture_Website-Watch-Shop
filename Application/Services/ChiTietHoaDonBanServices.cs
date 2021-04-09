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
    
    public class ChiTietHoaDonBanServices : IChiTietHoaDonBanServices
    {
        private readonly IChiTietHoaDonBanRepository _chiTietHoaDonBanRepository;//Tạo biến chứa dữ liệu 
        public ChiTietHoaDonBanServices(IChiTietHoaDonBanRepository chiTietHoaDonBanRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _chiTietHoaDonBanRepository = chiTietHoaDonBanRepository;
        }
        public IEnumerable<ChiTietHoaDonBanDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _chiTietHoaDonBanRepository.getAll().MappingChiTietHoaDonBanList();
        }
    }
}
