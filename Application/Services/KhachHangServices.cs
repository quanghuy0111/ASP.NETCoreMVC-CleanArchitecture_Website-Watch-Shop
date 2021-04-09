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
    
    public class KhachHangServices : IKhachHangServices
    {
        private readonly IKhachHangRepository _khachHangRepository;//Tạo biến chứa dữ liệu 
        public KhachHangServices(IKhachHangRepository khachHangRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _khachHangRepository = khachHangRepository;
        }

        public IEnumerable<KhachHangDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _khachHangRepository.getAll(pageIndex, pageSize, search, Type, out count).MappingKhachHangList();
        }
        public IEnumerable<KhachHangDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _khachHangRepository.getAll().MappingKhachHangList();
        }
        public KhachHangDTO GetKhachHang(string maKhachHang)
        {
            return _khachHangRepository.GetKhachHang(maKhachHang).MappingKhachHangDTO();

        }

        public void suaKhachHang(KhachHangDTO khachHangDTO)
        {
            _khachHangRepository.SuaKhachHang(khachHangDTO.MappingKhachHang());
        }

        public void themKhachHang(KhachHangDTO khachHangDTO)
        {
            _khachHangRepository.ThemKhachHang(khachHangDTO.MappingKhachHang());
        }


        public void xoaKhachHang(string maKhachHang)
        {
            _khachHangRepository.XoaKhachHang(maKhachHang);
        }
    }
}
