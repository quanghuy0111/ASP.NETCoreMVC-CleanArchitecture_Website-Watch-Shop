using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class SanPhamMapping
    {
        public static SanPhamDTO MappingSanPhamDTO(this SanPham sanPham)
        {
            return new SanPhamDTO
            {
                IDSanPham = sanPham.IDSanPham,
                TenSanPham = sanPham.TenSanPham,
                IDDay = sanPham.IDDay,
                IDThuongHieu = sanPham.IDThuongHieu,
                IDNhaCungCap = sanPham.IDNhaCungCap,
                BaoHanh = sanPham.BaoHanh,
                SoLuong = sanPham.SoLuong,
                Gia = sanPham.Gia,
                HinhAnh = sanPham.HinhAnh
            };
        }

        public static SanPham MappingSanPham(this SanPhamDTO sanPhamDTO)
        {
            return new SanPham
            {
                IDSanPham = sanPhamDTO.IDSanPham,
                TenSanPham = sanPhamDTO.TenSanPham,
                IDDay = sanPhamDTO.IDDay,
                IDThuongHieu = sanPhamDTO.IDThuongHieu,
                IDNhaCungCap = sanPhamDTO.IDNhaCungCap,
                BaoHanh = sanPhamDTO.BaoHanh,
                SoLuong = sanPhamDTO.SoLuong,
                Gia = sanPhamDTO.Gia,
                HinhAnh = sanPhamDTO.HinhAnh
            };
        }
        public static IEnumerable<SanPhamDTO> MappingSanPhamList(this IEnumerable<SanPham> sanPhamS)
        {
            List<SanPhamDTO> listreturn = new List<SanPhamDTO>();
            foreach (var sanPham in sanPhamS)
            {
                var obnow = sanPham.MappingSanPhamDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
