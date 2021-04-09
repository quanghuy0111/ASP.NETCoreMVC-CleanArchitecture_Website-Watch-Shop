using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
// using System.Data.Entity.IDatabaseInitializer<TContext>;
using Domain.Entities; 
namespace Infrastructure.Persistence
{
    public class DongHoContext: DbContext
    {
        public DongHoContext(DbContextOptions<DongHoContext> options): base(options)
        {
            
        }
        public DbSet<ChiTietHoaDonBan> chiTietHoaDonBan{get; set;}     
        public DbSet<ChiTietHoaDonNhap> chiTietHoaDonNhap{get; set;}
        public DbSet<HoaDonBan> hoaDonBan{get; set;}     
        public DbSet<HoaDonNhap> hoaDonNhap{get; set;}
        public DbSet<KhachHang> khachHang{get; set; }     
        public DbSet<LoaiDay> loaiDay{get; set;}
        public DbSet<NhaCungCap> nhaCungCap{get; set; }     
        public DbSet<SanPham> sanPham{get; set;}
        public DbSet<TaiKhoanKH> taiKhoanKH{get; set; }     
        public DbSet<ThuongHieu> thuongHieu{get; set;}
    }
}