using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class ChiTietHoaDonNhap
    {
        [Key]
        [Column(TypeName = "int")]
        public int IDChiTietHoaDonNhap{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDHoaDonNhap{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDSanPham{get; set;}

        [Column(TypeName = "int")]
        public int SoLuong{get; set;}
    }
}