using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class HoaDonBan
    {
        [Key]
        [Column(TypeName = "char(5)")]
        public string IDHoaDonBan{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDKhachHang{get; set;}

        [Column(TypeName = "float")]
        public float ThanhTien{get; set;}

        [Column(TypeName = "datetime")]
        public DateTime NgayBan{get; set;}

        [Column(TypeName = "nvarchar(20)")]
        public string TrangThai{get; set;}
    }
}