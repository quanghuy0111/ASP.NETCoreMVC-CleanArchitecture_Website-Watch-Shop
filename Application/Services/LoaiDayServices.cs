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
    
    public class LoaiDayServices : ILoaiDayServices
    {
        private readonly ILoaiDayRepository _loaiDayRepository;//Tạo biến chứa dữ liệu 
        public LoaiDayServices(ILoaiDayRepository loaiDayRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _loaiDayRepository = loaiDayRepository;
        }

        public IEnumerable<LoaiDayDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _loaiDayRepository.getAll(pageIndex, pageSize, search, Type, out count).MappingLoaiDayList();
        }
        public IEnumerable<LoaiDayDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _loaiDayRepository.getAll().MappingLoaiDayList();
        }
        public LoaiDayDTO GetLoaiDay(string maLoaiDay)
        {
            return _loaiDayRepository.GetLoaiDay(maLoaiDay).MappingLoaiDayDTO();

        }

        public void suaLoaiDay(LoaiDayDTO loaiDayDTO)
        {
            _loaiDayRepository.SuaLoaiDay(loaiDayDTO.MappingLoaiDay());
        }

        public void themLoaiDay(LoaiDayDTO loaiDayDTO)
        {
            _loaiDayRepository.ThemLoaiDay(loaiDayDTO.MappingLoaiDay());
        }


        public void xoaLoaiDay(string maLoaiDay)
        {
            _loaiDayRepository.XoaLoaiDay(maLoaiDay);
        }
    }
}
