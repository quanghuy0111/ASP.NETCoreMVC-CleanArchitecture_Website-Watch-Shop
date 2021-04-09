using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class NhaCungCapMapping
    {
        public static NhaCungCapDTO MappingNhaCungCapDTO(this NhaCungCap nhaCungCap)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new NhaCungCapDTO
            {
                IDNhaCungCap=nhaCungCap.IDNhaCungCap,
                TenNhacungCap=nhaCungCap.TenNhacungCap,
                DiaChi=nhaCungCap.DiaChi,
                SoDienThoai=nhaCungCap.SoDienThoai
            };
        }

        public static NhaCungCap MappingNhaCungCap(this NhaCungCapDTO nhaCungCapDTO)
        {
            return new NhaCungCap
            {
                IDNhaCungCap=nhaCungCapDTO.IDNhaCungCap,
                TenNhacungCap=nhaCungCapDTO.TenNhacungCap,
                DiaChi=nhaCungCapDTO.DiaChi,
                SoDienThoai=nhaCungCapDTO.SoDienThoai
            };
        }
        public static IEnumerable<NhaCungCapDTO> MappingNhaCungCapList(this IEnumerable<NhaCungCap> nhaCungCapS)
        {
            List<NhaCungCapDTO> listreturn = new List<NhaCungCapDTO>();
            foreach (var nhaCungCap in nhaCungCapS)
            {
                var obnow = nhaCungCap.MappingNhaCungCapDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
