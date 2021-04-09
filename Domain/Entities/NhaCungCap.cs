using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class NhaCungCap
    {
        [Key]
        [Column(TypeName = "char(5)")]
        public string IDNhaCungCap{get; set;}

        [Column(TypeName = "nvarchar(50)")]
        public string TenNhacungCap{get; set;}

        [Column(TypeName = "nvarchar(200)")]
        public string DiaChi{get; set;}

        [Column(TypeName = "varchar(10)")]
        public string SoDienThoai{get; set;}

    }
}