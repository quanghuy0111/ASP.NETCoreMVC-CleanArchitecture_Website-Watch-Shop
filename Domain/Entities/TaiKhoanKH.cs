using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class TaiKhoanKH
    {
        [Key]
        [Column(TypeName = "varchar(50)")]
        public string TaiKhoan{get; set;}

        [Column(TypeName = "varchar(50)")]
        public string MatKhau{get; set;}
        
        [Column(TypeName = "char(5)")]
        public string IDKhachHang{get; set;}
        
    }
}