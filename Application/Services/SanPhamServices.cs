using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class SanPhamServices : ISanPhamServices
    {
        private readonly ISanPhamRepository _sanPhamRepository;//Tạo biến chứa dữ liệu 
        public SanPhamServices(ISanPhamRepository sanPhamRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _sanPhamRepository = sanPhamRepository;
        }

        public IEnumerable<SanPhamDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _sanPhamRepository.getAll(pageIndex, pageSize, search, Type, out count).MappingSanPhamList();
        }
        public IEnumerable<SanPhamDTO> getAll(int pageIndex, int pageSize, string textSearch, string type, bool price, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _sanPhamRepository.getAll(pageIndex, pageSize, textSearch, type, price, out count).MappingSanPhamList();
        }
        public IEnumerable<SanPhamDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _sanPhamRepository.getAll().MappingSanPhamList();
        }
        public SanPhamDTO GetSanPham(string maSanPham)
        {
            return _sanPhamRepository.GetSanPham(maSanPham).MappingSanPhamDTO();

        }

        public void suaSanPham(SanPhamDTO sanPhamDTO)
        {
            _sanPhamRepository.SuaSanPham(sanPhamDTO.MappingSanPham());
        }

        public void themSanPham(SanPhamDTO sanPhamDTO)
        {
            _sanPhamRepository.ThemSanPham(sanPhamDTO.MappingSanPham());
        }


        public void xoaSanPham(string maSanPham)
        {
            _sanPhamRepository.XoaSanPham(maSanPham);
        }
        public IEnumerable<SanPhamDTO> get4sp(int boqua)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _sanPhamRepository.get4sp(boqua).MappingSanPhamList();
        }
        public SanPhamDTO Xemsp(string maSanPham)
        {
            return _sanPhamRepository.Xemsp(maSanPham).MappingSanPhamDTO();

        }
    }
}
