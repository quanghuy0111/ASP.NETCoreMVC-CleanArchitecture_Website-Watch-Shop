using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class LoaiDayMapping
    {
        public static LoaiDayDTO MappingLoaiDayDTO(this LoaiDay loaiDay)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new LoaiDayDTO
            {
                IDDay=loaiDay.IDDay,
                TenLoaiDay=loaiDay.TenLoaiDay
            };
        }

        public static LoaiDay MappingLoaiDay(this LoaiDayDTO loaiDayDTO)
        {
            return new LoaiDay
            {
                IDDay=loaiDayDTO.IDDay,
                TenLoaiDay=loaiDayDTO.TenLoaiDay
            };
        }
        public static IEnumerable<LoaiDayDTO> MappingLoaiDayList(this IEnumerable<LoaiDay> loaiDayS)
        {
            List<LoaiDayDTO> listreturn = new List<LoaiDayDTO>();
            foreach (var loaiDay in loaiDayS)
            {
                var obnow = loaiDay.MappingLoaiDayDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
