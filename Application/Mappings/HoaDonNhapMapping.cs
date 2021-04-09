using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class HoaDonNhapMapping
    {
        public static HoaDonNhapDTO MappingHoaDonNhapDTO(this HoaDonNhap hoaDonNhap)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new HoaDonNhapDTO
            {
                IDHoaDonNhap=hoaDonNhap.IDHoaDonNhap,
                IDNhaCungCap=hoaDonNhap.IDNhaCungCap,
                ThanhTien=hoaDonNhap.ThanhTien,
                NgayNhap=hoaDonNhap.NgayNhap
            };
        }

        public static HoaDonNhap MappingHoaDonNhap(this HoaDonNhapDTO hoaDonNhapDTO)
        {
            return new HoaDonNhap
            {
                IDHoaDonNhap=hoaDonNhapDTO.IDHoaDonNhap,
                IDNhaCungCap=hoaDonNhapDTO.IDNhaCungCap,
                ThanhTien=hoaDonNhapDTO.ThanhTien,
                NgayNhap=hoaDonNhapDTO.NgayNhap
            };
        }
        public static IEnumerable<HoaDonNhapDTO> MappingHoaDonNhapList(this IEnumerable<HoaDonNhap> HoaDonNhapS)
        {
            List<HoaDonNhapDTO> listreturn = new List<HoaDonNhapDTO>(); 
            foreach (var HoaDonNhap in HoaDonNhapS)
            {
                var obnow = HoaDonNhap.MappingHoaDonNhapDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
