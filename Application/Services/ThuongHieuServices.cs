using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class ThuongHieuServices : IThuongHieuServices
    {
        private readonly IThuongHieuRepository _thuongHieuRepository;//Tạo biến chứa dữ liệu 
        public ThuongHieuServices(IThuongHieuRepository thuongHieuRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _thuongHieuRepository = thuongHieuRepository;
        }

        public IEnumerable<ThuongHieuDTO> getAll(int pageIndex, int pageSize,string search,string Type,out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _thuongHieuRepository.getAll(pageIndex,pageSize,search,Type,out count).MappingThuongHieuList();
        }
        public IEnumerable<ThuongHieuDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _thuongHieuRepository.getAll().MappingThuongHieuList();
        }
        public ThuongHieuDTO GetThuongHieu(string maThuongHieu)
        {
           return  _thuongHieuRepository.GetThuongHieu(maThuongHieu).MappingThuongHieuDTO();

        }

        public void suaThuongHieu(ThuongHieuDTO thuongHieuDTO)
        {
            _thuongHieuRepository.SuaThuongHieu(thuongHieuDTO.MappingThuongHieu());
        }

        public void themThuongHieu(ThuongHieuDTO thuongHieuDTO)
        {
            _thuongHieuRepository.ThemThuongHieu(thuongHieuDTO.MappingThuongHieu());
        }


        public void xoaThuongHieu(string maThuongHieu)
        {
            _thuongHieuRepository.XoaThuongHieu(maThuongHieu);
        }
    }
}
