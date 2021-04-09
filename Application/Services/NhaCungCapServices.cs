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
    
    public class NhaCungCapServices : INhaCungCapServices
    {
        private readonly INhaCungCapRepository _nhaCungCapRepository;//Tạo biến chứa dữ liệu 
        public NhaCungCapServices(INhaCungCapRepository nhaCungCapRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _nhaCungCapRepository = nhaCungCapRepository;
        }

        public IEnumerable<NhaCungCapDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _nhaCungCapRepository.getAll(pageIndex, pageSize, search, Type, out count).MappingNhaCungCapList();
        }
        public IEnumerable<NhaCungCapDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _nhaCungCapRepository.getAll().MappingNhaCungCapList();
        }
        public NhaCungCapDTO GetNhaCungCap(string maNhaCungCap)
        {
            return _nhaCungCapRepository.GetNhaCungCap(maNhaCungCap).MappingNhaCungCapDTO();

        }

        public void suaNhaCungCap(NhaCungCapDTO nhaCungCapDTO)
        {
            _nhaCungCapRepository.SuaNhaCungCap(nhaCungCapDTO.MappingNhaCungCap());
        }

        public void themNhaCungCap(NhaCungCapDTO nhaCungCapDTO)
        {
            _nhaCungCapRepository.ThemNhaCungCap(nhaCungCapDTO.MappingNhaCungCap());
        }


        public void xoaNhaCungCap(string maNhaCungCap)
        {
            _nhaCungCapRepository.XoaNhaCungCap(maNhaCungCap);
        }


    }
}
