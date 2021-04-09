using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class KhachHangMapping
    {
        public static KhachHangDTO MappingKhachHangDTO(this KhachHang khachHang)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new KhachHangDTO
            {
                IDKhachHang=khachHang.IDKhachHang,
                HoKhachHang=khachHang.HoKhachHang,
                TenKhachHang=khachHang.TenKhachHang,
                DiaChiNhanHang=khachHang.DiaChiNhanHang,
                SoDienThoai=khachHang.SoDienThoai
            };
        }

        public static KhachHang MappingKhachHang(this KhachHangDTO khachHangDTO)
        {
            return new KhachHang
            {
                IDKhachHang=khachHangDTO.IDKhachHang,
                HoKhachHang=khachHangDTO.HoKhachHang,
                TenKhachHang=khachHangDTO.TenKhachHang,
                DiaChiNhanHang=khachHangDTO.DiaChiNhanHang,
                SoDienThoai=khachHangDTO.SoDienThoai
            };
        }
        public static IEnumerable<KhachHangDTO> MappingKhachHangList(this IEnumerable<KhachHang> khachHangS)
        {
            List<KhachHangDTO> listreturn = new List<KhachHangDTO>();
            foreach (var khachHang in khachHangS)
            {
                var obnow = khachHang.MappingKhachHangDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
