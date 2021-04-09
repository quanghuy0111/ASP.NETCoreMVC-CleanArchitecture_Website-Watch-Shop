using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class ChiTietHoaDonBanMapping
    {
        public static ChiTietHoaDonBanDTO MappingChiTietHoaDonBanDTO(this ChiTietHoaDonBan chiTietHoaDonBan)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new ChiTietHoaDonBanDTO
            {
                IDChiTietHoaDonBan=chiTietHoaDonBan.IDChiTietHoaDonBan,
                IDHoaDon=chiTietHoaDonBan.IDHoaDon,
                IDSanPham=chiTietHoaDonBan.IDSanPham,
                SoLuong=chiTietHoaDonBan.SoLuong
            };
        }

        public static ChiTietHoaDonBan MappingChiTietHoaDonBan(this ChiTietHoaDonBanDTO chiTietHoaDonBanDTO)
        {
            return new ChiTietHoaDonBan
            {
                IDChiTietHoaDonBan=chiTietHoaDonBanDTO.IDChiTietHoaDonBan,
                IDHoaDon=chiTietHoaDonBanDTO.IDHoaDon,
                IDSanPham=chiTietHoaDonBanDTO.IDSanPham,
                SoLuong=chiTietHoaDonBanDTO.SoLuong
            };
        }
        public static IEnumerable<ChiTietHoaDonBanDTO> MappingChiTietHoaDonBanList(this IEnumerable<ChiTietHoaDonBan> ChiTietHoaDonBanS)
        {
            List<ChiTietHoaDonBanDTO> listreturn = new List<ChiTietHoaDonBanDTO>(); 
            foreach (var ChiTietHoaDonBan in ChiTietHoaDonBanS)
            {
                var obnow = ChiTietHoaDonBan.MappingChiTietHoaDonBanDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
