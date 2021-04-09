using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class HoaDonNhap
    {
        [Key]
        [Column(TypeName = "char(5)")]
        public string IDHoaDonNhap{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDNhaCungCap{get; set;}

        [Column(TypeName = "float")]
        public float ThanhTien{get; set;}

        [Column(TypeName = "datetime")]
        public DateTime NgayNhap{get; set;}

    }
}