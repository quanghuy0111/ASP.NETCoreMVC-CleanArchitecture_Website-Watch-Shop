using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class TaiKhoanKHMapping
    {
        public static TaiKhoanKHDTO MappingTaiKhoanKHDTO(this TaiKhoanKH taiKhoanKH)
        {
            return new TaiKhoanKHDTO
            {
                TaiKhoan = taiKhoanKH.TaiKhoan,
                MatKhau = taiKhoanKH.MatKhau,
                IDKhachHang = taiKhoanKH.IDKhachHang
            };
        }
        public static TaiKhoanKH MappingTaiKhoanKH(this TaiKhoanKHDTO taiKhoanKHDTO)
        {
            return new TaiKhoanKH
            {
                TaiKhoan = taiKhoanKHDTO.TaiKhoan,
                MatKhau = taiKhoanKHDTO.MatKhau,
                IDKhachHang = taiKhoanKHDTO.IDKhachHang
            };
        }
        public static IEnumerable<TaiKhoanKHDTO> MappingTaiKhoanKHList(this IEnumerable<TaiKhoanKH> taiKhoanKHS)
        {
            List<TaiKhoanKHDTO> listreturn = new List<TaiKhoanKHDTO>();
            foreach (var taiKhoanKH in taiKhoanKHS)
            {
                var obnow = taiKhoanKH.MappingTaiKhoanKHDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }

    }
}
