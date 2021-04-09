using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class HoaDonBanMapping
    {
        public static HoaDonBanDTO MappingHoaDonBanDTO(this HoaDonBan hoaDonBan)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new HoaDonBanDTO
            {
                IDHoaDonBan=hoaDonBan.IDHoaDonBan,
                IDKhachHang=hoaDonBan.IDKhachHang,
                ThanhTien=hoaDonBan.ThanhTien,
                NgayBan=hoaDonBan.NgayBan,
                TrangThai=hoaDonBan.TrangThai
            };
        }

        public static HoaDonBan MappingHoaDonBan(this HoaDonBanDTO hoaDonBanDTO)
        {
            return new HoaDonBan
            {
                IDHoaDonBan=hoaDonBanDTO.IDHoaDonBan,
                IDKhachHang=hoaDonBanDTO.IDKhachHang,
                ThanhTien=hoaDonBanDTO.ThanhTien,
                NgayBan=hoaDonBanDTO.NgayBan,
                TrangThai=hoaDonBanDTO.TrangThai
            };
        }
        public static IEnumerable<HoaDonBanDTO> MappingHoaDonBanList(this IEnumerable<HoaDonBan> HoaDonBanS)
        {
            List<HoaDonBanDTO> listreturn = new List<HoaDonBanDTO>(); 
            foreach (var HoaDonBan in HoaDonBanS)
            {
                var obnow = HoaDonBan.MappingHoaDonBanDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
