using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chiTietHoaDonBan",
                columns: table => new
                {
                    IDChiTietHoaDonBan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHoaDon = table.Column<string>(type: "char(5)", nullable: true),
                    IDSanPham = table.Column<string>(type: "char(5)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietHoaDonBan", x => x.IDChiTietHoaDonBan);
                });

            migrationBuilder.CreateTable(
                name: "chiTietHoaDonNhap",
                columns: table => new
                {
                    IDChiTietHoaDonNhap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHoaDonNhap = table.Column<string>(type: "char(5)", nullable: true),
                    IDSanPham = table.Column<string>(type: "char(5)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietHoaDonNhap", x => x.IDChiTietHoaDonNhap);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonBan",
                columns: table => new
                {
                    IDHoaDonBan = table.Column<string>(type: "char(5)", nullable: false),
                    IDKhachHang = table.Column<string>(type: "char(5)", nullable: true),
                    ThanhTien = table.Column<double>(type: "float", nullable: false),
                    NgayBan = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonBan", x => x.IDHoaDonBan);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonNhap",
                columns: table => new
                {
                    IDHoaDonNhap = table.Column<string>(type: "char(5)", nullable: false),
                    IDNhaCungCap = table.Column<string>(type: "char(5)", nullable: true),
                    ThanhTien = table.Column<double>(type: "float", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonNhap", x => x.IDHoaDonNhap);
                });

            migrationBuilder.CreateTable(
                name: "khachHang",
                columns: table => new
                {
                    IDKhachHang = table.Column<string>(type: "char(5)", nullable: false),
                    HoKhachHang = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TenKhachHang = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChiNhanHang = table.Column<string>(type: "varchar(200)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHang", x => x.IDKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "loaiDay",
                columns: table => new
                {
                    IDDay = table.Column<string>(type: "char(5)", nullable: false),
                    TenLoaiDay = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiDay", x => x.IDDay);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCap",
                columns: table => new
                {
                    IDNhaCungCap = table.Column<string>(type: "char(5)", nullable: false),
                    TenNhacungCap = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCap", x => x.IDNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "sanPham",
                columns: table => new
                {
                    IDSanPham = table.Column<string>(type: "char(5)", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IDDay = table.Column<string>(type: "char(5)", nullable: true),
                    IDThuongHieu = table.Column<string>(type: "char(5)", nullable: true),
                    IDNhaCungCap = table.Column<string>(type: "char(5)", nullable: true),
                    BaoHanh = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham", x => x.IDSanPham);
                });

            migrationBuilder.CreateTable(
                name: "taiKhoanKH",
                columns: table => new
                {
                    TaiKhoan = table.Column<string>(type: "varchar(50)", nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(50)", nullable: true),
                    IDKhachHang = table.Column<string>(type: "char(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taiKhoanKH", x => x.TaiKhoan);
                });

            migrationBuilder.CreateTable(
                name: "thuongHieu",
                columns: table => new
                {
                    IDThuongHieu = table.Column<string>(type: "char(5)", nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thuongHieu", x => x.IDThuongHieu);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietHoaDonBan");

            migrationBuilder.DropTable(
                name: "chiTietHoaDonNhap");

            migrationBuilder.DropTable(
                name: "hoaDonBan");

            migrationBuilder.DropTable(
                name: "hoaDonNhap");

            migrationBuilder.DropTable(
                name: "khachHang");

            migrationBuilder.DropTable(
                name: "loaiDay");

            migrationBuilder.DropTable(
                name: "nhaCungCap");

            migrationBuilder.DropTable(
                name: "sanPham");

            migrationBuilder.DropTable(
                name: "taiKhoanKH");

            migrationBuilder.DropTable(
                name: "thuongHieu");
        }
    }
}
