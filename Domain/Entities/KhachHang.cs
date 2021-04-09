using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class KhachHang
    {
        [Key]
        [Column(TypeName = "char(5)")]
        public string IDKhachHang{get; set;}

        [Column(TypeName = "nvarchar(50)")]
        public string HoKhachHang{get; set;}

        [Column(TypeName = "nvarchar(50)")]
        public string TenKhachHang{get; set;}

        [Column(TypeName = "varchar(200)")]
        public string DiaChiNhanHang{get; set;}
        
        [Column(TypeName = "varchar(10)")]
        public string SoDienThoai{get; set;}
    }
}