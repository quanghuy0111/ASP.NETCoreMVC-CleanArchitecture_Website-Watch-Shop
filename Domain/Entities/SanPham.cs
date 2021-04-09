using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class SanPham
    {
        [Key]
        [Column(TypeName = "char(5)")]
        public string IDSanPham{get; set;}

        [Column(TypeName = "nvarchar(50)")]
        public string TenSanPham{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDDay{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDThuongHieu{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDNhaCungCap{get; set;}

        [Column(TypeName = "nvarchar(20)")]
        public string BaoHanh{get; set;}

        [Column(TypeName = "int")]
        public int SoLuong{get; set;}

        [Column(TypeName = "float")]
        public float Gia{get; set;}

        [Column(TypeName = "string")]
        public string HinhAnh { get; set; }
    }
}