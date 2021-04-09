using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DongHoContext(
                serviceProvider.GetRequiredService<DbContextOptions<DongHoContext>>()))
            {
                //link tham khảo https://stackoverflow.com/questions/38238043how-and-where-to-call-database-ensurecreated-and-database-migrate
                context.Database.Migrate();//Hàm này sẽ tạo db nếu chưa có và sẽ không làm gì nếu có rồi , chạy dựa trên file migration
                
                //KhachHang
                if (context.khachHang.Any()) return;
                context.khachHang.AddRange(
                    new Domain.Entities.KhachHang
                    {
                        IDKhachHang = "KH000",
                        HoKhachHang = "admin",
                        TenKhachHang = "admin",
                        DiaChiNhanHang = " ",
                        SoDienThoai = " "
                    },
                    new Domain.Entities.KhachHang
                    {
                        IDKhachHang = "KH001",
                        HoKhachHang = "Nguyễn",
                        TenKhachHang = "Phát",    
                        DiaChiNhanHang = "Dang Chat",
                        SoDienThoai = "0982765221"
                    },
                    new Domain.Entities.KhachHang
                    {
                        IDKhachHang = "KH002",
                        HoKhachHang = "Lê",
                        TenKhachHang = "Nhân",
                        DiaChiNhanHang = "Duong Ba Trac",
                        SoDienThoai = "0788889378"
                    },
                    new Domain.Entities.KhachHang
                    {
                        IDKhachHang = "KH003",
                        HoKhachHang = "Nguyễn",
                        TenKhachHang = "Nguyên",
                        DiaChiNhanHang = "Tam Danh",
                        SoDienThoai = "0944449394"
                    },
                    new Domain.Entities.KhachHang
                    {
                        IDKhachHang = "KH004",
                        HoKhachHang = "Cao",
                        TenKhachHang = "Hưng",
                        DiaChiNhanHang = "Ta Quang Buu",
                        SoDienThoai = "0909189189"
                    },
                    new Domain.Entities.KhachHang
                    {
                        IDKhachHang = "KH005",
                        HoKhachHang = "Nguyễn",
                        TenKhachHang = "Huy",
                        DiaChiNhanHang = "Au Duong Lan",
                        SoDienThoai = "0906600189"
                    }
                    );
                context.SaveChanges();
                
                //TaiKhoan
                if (context.taiKhoanKH.Any()) return;
                context.taiKhoanKH.AddRange(
                    new Domain.Entities.TaiKhoanKH
                    {
                        TaiKhoan = "admin",
                        MatKhau = "123456",
                        IDKhachHang = "KH000"
                    },
                    new Domain.Entities.TaiKhoanKH
                    {
                        TaiKhoan = "nguyenphat",
                        MatKhau = "abcdef",
                        IDKhachHang = "KH001"
                    },
                    new Domain.Entities.TaiKhoanKH
                    {
                        TaiKhoan = "lenhan",
                        MatKhau = "290620",
                        IDKhachHang = "KH002"
                    },
                    new Domain.Entities.TaiKhoanKH
                    {
                        TaiKhoan = "nguyennguyen",
                        MatKhau = "456789",
                        IDKhachHang = "KH003"
                    },
                    new Domain.Entities.TaiKhoanKH
                    {
                        TaiKhoan = "caohung",
                        MatKhau = "iklmno",
                        IDKhachHang = "KH004"
                    },
                    new Domain.Entities.TaiKhoanKH
                    {
                        TaiKhoan = "nguyenhuy",
                        MatKhau = "qwerty",
                        IDKhachHang = "KH005"
                    }
                    );
                context.SaveChanges();
                
                //ThuongHieu
                if (context.thuongHieu.Any()) return;
                context.thuongHieu.AddRange(
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH001",
                        TenThuongHieu = "ADRIATICA",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH002",
                        TenThuongHieu = "CANDINO",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH003",
                        TenThuongHieu = "CASIO",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH004",
                        TenThuongHieu = "CITIZEN",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH005",
                        TenThuongHieu = "DANIEL WELLINGTON",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH006",
                        TenThuongHieu = "FOSSIL",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH007",
                        TenThuongHieu = "FOUETTÉ",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH008",
                        TenThuongHieu = "G-SHOCK & BABY-G",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH009",
                        TenThuongHieu = "MICHAEL KORS",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH010",
                        TenThuongHieu = "OP",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH011",
                        TenThuongHieu = "ORIENT",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH012",
                        TenThuongHieu = "SAGA",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH013",
                        TenThuongHieu = "SEIKO",
                    },
                    new Domain.Entities.ThuongHieu
                    {
                        IDThuongHieu = "TH014",
                        TenThuongHieu = "SKAGEN",
                    }
                    );
                context.SaveChanges();
                
                //LoaiDay
                if (context.loaiDay.Any()) return;
                context.loaiDay.AddRange(
                    new Domain.Entities.LoaiDay
                    {
                        IDDay = "LD001",
                        TenLoaiDay = "Dây da"
                    },
                    new Domain.Entities.LoaiDay
                    {
                        IDDay = "LD002",
                        TenLoaiDay = "Dây vải"
                    },
                    new Domain.Entities.LoaiDay
                    {
                        IDDay = "LD003",
                        TenLoaiDay = "Dây cao su"
                    },
                    new Domain.Entities.LoaiDay
                    {
                        IDDay = "LD004",
                        TenLoaiDay = "Thép không gỉ"
                    }
                    );
                context.SaveChanges();
                
                //NhaCungCap
                if (context.nhaCungCap.Any()) return;
                context.nhaCungCap.AddRange(
                    new Domain.Entities.NhaCungCap
                    {
                        IDNhaCungCap = "NC001",
                        TenNhacungCap = "Nhật Bản",
                        DiaChi = "Tan Binh",
                        SoDienThoai = "0123456789"
                    },
                    new Domain.Entities.NhaCungCap
                    {
                        IDNhaCungCap = "NC002",
                        TenNhacungCap = "Mỹ",
                        DiaChi = "Tan Phu",
                        SoDienThoai = "0234567891"
                    },
                    new Domain.Entities.NhaCungCap
                    {
                        IDNhaCungCap = "NC003",
                        TenNhacungCap = "Đan Mạch",
                        DiaChi = "Thu Duc",
                        SoDienThoai = "0345678912"
                    },
                    new Domain.Entities.NhaCungCap
                    {
                        IDNhaCungCap = "NC004",
                        TenNhacungCap = "Thụy Sĩ",
                        DiaChi = "Binh Tan",
                        SoDienThoai = "0456789123"
                    },
                    new Domain.Entities.NhaCungCap
                    {
                        IDNhaCungCap = "NC005",
                        TenNhacungCap = "Thụy Điển",
                        DiaChi = "Binh Thanh",
                        SoDienThoai = "0567891234"
                    },
                    new Domain.Entities.NhaCungCap
                    {
                        IDNhaCungCap = "NC006",
                        TenNhacungCap = "Hồng Kông",
                        DiaChi = "Phu Nhuan",
                        SoDienThoai = "0678912345"
                    }
                    );
                context.SaveChanges();
                
                //SanPham
                if (context.sanPham.Any()) return;
                context.sanPham.AddRange(
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP001",
                        TenSanPham = "Orient_FAG02004B0",
                        IDDay = "LD001",
                        IDThuongHieu = "TH011",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5810000"),
                        HinhAnh = "/images/DATA/Orient_FAG02004B0.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP002",
                        TenSanPham = "Orient_FAL00003W0",
                        IDDay = "LD004",
                        IDThuongHieu = "TH011",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6170000"),
                        HinhAnh = "/images/DATA/Orient_FAL00003W0.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP003",
                        TenSanPham = "Orient_FET0P002B0",
                        IDDay = "LD004",
                        IDThuongHieu = "TH011",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("9080000"),
                        HinhAnh = "/images/DATA/Orient_FET0P002B0.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP004",
                        TenSanPham = "Orient_FGW01004A0",
                        IDDay = "LD001",
                        IDThuongHieu = "TH011",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3810000"),
                        HinhAnh = "/images/DATA/Orient_FGW01004A0.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP005",
                        TenSanPham = "Orient_RA-AC0011S10B",
                        IDDay = "LD001",
                        IDThuongHieu = "TH011",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("7080000"),
                        HinhAnh = "/images/DATA/Orient_RA-AC0011S10B.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP006",
                        TenSanPham = "Fouette_OR-FAIRYIII",
                        IDDay = "LD001",
                        IDThuongHieu = "TH007",
                        IDNhaCungCap = "NC006",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2550000"),
                        HinhAnh = "/images/DATA/Fouette_OR-FAIRYIII.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP007",
                        TenSanPham = "Fouette_OR-5",
                        IDDay = "LD001",
                        IDThuongHieu = "TH007",
                        IDNhaCungCap = "NC006",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("1550000"),
                        HinhAnh = "/images/DATA/Fouette_OR-5.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP008",
                        TenSanPham = "Fouette_OR-STAR",
                        IDDay = "LD001",
                        IDThuongHieu = "TH007",
                        IDNhaCungCap = "NC006",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("1550000"),
                        HinhAnh = "/images/DATA/Fouette_OR-STAR.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP009",
                        TenSanPham = "Fouette_OR-LOVE",
                        IDDay = "LD001",
                        IDThuongHieu = "TH007",
                        IDNhaCungCap = "NC006",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("1550000"),
                        HinhAnh = "/images/DATA/Fouette_OR-LOVE.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP010",
                        TenSanPham = "Casio_EFV-540DC-1BVUDF",
                        IDDay = "LD004",
                        IDThuongHieu = "TH003",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4489000"),
                        HinhAnh = "/images/DATA/Casio_EFV-540DC-1BVUDF.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP011",
                        TenSanPham = "Casio_MTP-VD300L-1EUDF",
                        IDDay = "LD001",
                        IDThuongHieu = "TH003",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("1457000"),
                        HinhAnh = "/images/DATA/Casio_MTP-VD300L-1EUDF.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP012",
                        TenSanPham = "Casio_LTP-1170N-9ARDF",
                        IDDay = "LD004",
                        IDThuongHieu = "TH003",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("1387000"),
                        HinhAnh = "/images/DATA/Casio_LTP-1170N-9ARDF.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP013",
                        TenSanPham = "Casio_MW-240-7EVDF",
                        IDDay = "LD003",
                        IDThuongHieu = "TH003",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("517000"),
                        HinhAnh = "/images/DATA/Casio_MW-240-7EVDF.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP014",
                        TenSanPham = "Casio_AE1200WHD",
                        IDDay = "LD004",
                        IDThuongHieu = "TH003",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("1246000"),
                        HinhAnh = "/images/DATA/Casio_AE1200WHD.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP015",
                        TenSanPham = "G-Shock_DW-5600MS-1DR",
                        IDDay = "LD003",
                        IDThuongHieu = "TH008",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3169000"),
                        HinhAnh = "/images/DATA/G-Shock_DW-5600MS-1DR.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP016",
                        TenSanPham = "G-Shock_GAX-100MSB-1ADR",
                        IDDay = "LD003",
                        IDThuongHieu = "TH008",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5100000"),
                        HinhAnh = "/images/DATA/G-Shock_GAX-100MSB-1ADR.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP017",
                        TenSanPham = "Baby-G_MSG-S200-7ADR",
                        IDDay = "LD003",
                        IDThuongHieu = "TH008",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3737000"),
                        HinhAnh = "/images/DATA/Baby-G_MSG-S200-7ADR.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP018",
                        TenSanPham = "G-Shock_GST-S310D-1A9DR",
                        IDDay = "LD004",
                        IDThuongHieu = "TH008",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("10364000"),
                        HinhAnh = "/images/DATA/G-Shock_GST-S310D-1A9DR.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP019",
                        TenSanPham = "G-Shock_GA-200RG-1ADR",
                        IDDay = "LD003",
                        IDThuongHieu = "TH008",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5452000"),
                        HinhAnh = "/images/DATA/G-Shock_GA-200RG-1ADR.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP020",
                        TenSanPham = "Citizen_NH8350-59L",
                        IDDay = "LD004",
                        IDThuongHieu = "TH004",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5520000"),
                        HinhAnh = "/images/DATA/Citizen_NH8350-59L.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP021",
                        TenSanPham = "Citizen_BH3003-51A",
                        IDDay = "LD004",
                        IDThuongHieu = "TH004",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4300000"),
                        HinhAnh = "/images/DATA/Citizen_BH3003-51A.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP022",
                        TenSanPham = "Citizen_BI1050-05A",
                        IDDay = "LD002",
                        IDThuongHieu = "TH004",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2700000"),
                        HinhAnh = "/images/DATA/Citizen_BI1050-05A.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP023",
                        TenSanPham = "Citizen_BM9012-02A",
                        IDDay = "LD001",
                        IDThuongHieu = "TH004",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6600000"),
                        HinhAnh = "/images/DATA/Citizen_BM9012-02A.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP024",
                        TenSanPham = "Citizen_CA4425-10X",
                        IDDay = "LD001",
                        IDThuongHieu = "TH004",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("7750000"),
                        HinhAnh = "/images/DATA/Citizen_CA4425-10X.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP025",
                        TenSanPham = "Fossil_ES4821",
                        IDDay = "LD004",
                        IDThuongHieu = "TH006",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3480000"),
                        HinhAnh = "/images/DATA/Fossil_ES4821.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP026",
                        TenSanPham = "Fossil_ES4534",
                        IDDay = "LD004",
                        IDThuongHieu = "TH006",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4020000"),
                        HinhAnh = "/images/DATA/Fossil_ES4534.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP027",
                        TenSanPham = "Fossil_ES4837",
                        IDDay = "LD004",
                        IDThuongHieu = "TH006",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3480000"),
                        HinhAnh = "/images/DATA/Fossil_ES4837.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP028",
                        TenSanPham = "Fossil_ES4433",
                        IDDay = "LD004",
                        IDThuongHieu = "TH006",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3380000"),
                        HinhAnh = "/images/DATA/Fossil_ES4433.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP029",
                        TenSanPham = "Fossil_ES4671",
                        IDDay = "LD004",
                        IDThuongHieu = "TH006",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3480000"),
                        HinhAnh = "/images/DATA/Fossil_ES4671.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP030",
                        TenSanPham = "Skagen_SKW6654",
                        IDDay = "LD001",
                        IDThuongHieu = "TH014",
                        IDNhaCungCap = "NC003",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2960000"),
                        HinhAnh = "/images/DATA/Skagen_SKW6654.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP031",
                        TenSanPham = "Skagen_SKW6454",
                        IDDay = "LD002",
                        IDThuongHieu = "TH014",
                        IDNhaCungCap = "NC003",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4630000"),
                        HinhAnh = "/images/DATA/Skagen_SKW6454.jpg"
                    }, 
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP032",
                        TenSanPham = "Skagen_SKW6578",
                        IDDay = "LD001",
                        IDThuongHieu = "TH014",
                        IDNhaCungCap = "NC003",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2960000"),
                        HinhAnh = "/images/DATA/Skagen_SKW6578.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP033",
                        TenSanPham = "Skagen_SKW2699",
                        IDDay = "LD004",
                        IDThuongHieu = "TH014",
                        IDNhaCungCap = "NC003",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3280000"),
                        HinhAnh = "/images/DATA/Skagen_SKW2699.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP034",
                        TenSanPham = "Skagen_456SSS",
                        IDDay = "LD004",
                        IDThuongHieu = "TH014",
                        IDNhaCungCap = "NC003",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4350000"),
                        HinhAnh = "/images/DATA/Skagen_456SSS.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP035",
                        TenSanPham = "Seiko_SPB121J1",
                        IDDay = "LD001",
                        IDThuongHieu = "TH013",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("24840000"),
                        HinhAnh = "/images/DATA/Seiko_SPB121J1.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP036",
                        TenSanPham = "Seiko_SSC715P1",
                        IDDay = "LD004",
                        IDThuongHieu = "TH013",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("8720000"),
                        HinhAnh = "/images/DATA/Seiko_SSC715P1.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP037",
                        TenSanPham = "Seiko_SRPC91K1",
                        IDDay = "LD003",
                        IDThuongHieu = "TH013",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("11820000"),
                        HinhAnh = "/images/DATA/Seiko_SRPC91K1.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP038",
                        TenSanPham = "Seiko_SSA383K1",
                        IDDay = "LD002",
                        IDThuongHieu = "TH013",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("7540000"),
                        HinhAnh = "/images/DATA/Seiko_SSA383K1.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP039",
                        TenSanPham = "Seiko_SSA810J1",
                        IDDay = "LD004",
                        IDThuongHieu = "TH013",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("13070000"),
                        HinhAnh = "/images/DATA/Seiko_SSA810J1.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP040",
                        TenSanPham = "OP_89322GS-T",
                        IDDay = "LD004",
                        IDThuongHieu = "TH010",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2840000"),
                        HinhAnh = "/images/DATA/OP_89322GS-T.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP041",
                        TenSanPham = "OP_130MS-GL-T-06",
                        IDDay = "LD001",
                        IDThuongHieu = "TH010",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2000000"),
                        HinhAnh = "/images/DATA/OP_130MS-GL-T-06.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP042",
                        TenSanPham = "OP_9908AGS-D-88",
                        IDDay = "LD004",
                        IDThuongHieu = "TH010",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6970000"),
                        HinhAnh = "/images/DATA/OP_9908AGS-D-88.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP043",
                        TenSanPham = "OP_5695MS-T",
                        IDDay = "LD004",
                        IDThuongHieu = "TH010",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2800000"),
                        HinhAnh = "/images/DATA/OP_5695MS-T.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP044",
                        TenSanPham = "OP_5695LSK-V",
                        IDDay = "LD004",
                        IDThuongHieu = "TH010",
                        IDNhaCungCap = "NC001",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("2920000"),
                        HinhAnh = "/images/DATA/OP_5695LSK-V.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP045",
                        TenSanPham = "MichaelKors_MK3191",
                        IDDay = "LD004",
                        IDThuongHieu = "TH009",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6910000"),
                        HinhAnh = "/images/DATA/MichaelKors_MK3191.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP046",
                        TenSanPham = "MichaelKors_MK4409",
                        IDDay = "LD004",
                        IDThuongHieu = "TH009",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6760000"),
                        HinhAnh = "/images/DATA/MichaelKors_MK4409.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP047",
                        TenSanPham = "MichaelKors_MK8752",
                        IDDay = "LD004",
                        IDThuongHieu = "TH009",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6910000"),
                        HinhAnh = "/images/DATA/MichaelKors_MK8752.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP048",
                        TenSanPham = "MichaelKors_MK8631",
                        IDDay = "LD001",
                        IDThuongHieu = "TH009",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5400000"),
                        HinhAnh = "/images/DATA/MichaelKors_MK8631.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP049",
                        TenSanPham = "MichaelKors_MK2715",
                        IDDay = "LD001",
                        IDThuongHieu = "TH009",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5270000"),
                        HinhAnh = "/images/DATA/MichaelKors_MK2715.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP050",
                        TenSanPham = "DanielWellington_DW00100014",
                        IDDay = "LD001",
                        IDThuongHieu = "TH005",
                        IDNhaCungCap = "NC005",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5300000"),
                        HinhAnh = "/images/DATA/DanielWellington_DW00100014.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP051",
                        TenSanPham = "DanielWellington_DW00100311",
                        IDDay = "LD002",
                        IDThuongHieu = "TH005",
                        IDNhaCungCap = "NC005",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("3500000"),
                        HinhAnh = "/images/DATA/DanielWellington_DW00100311.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP052",
                        TenSanPham = "DanielWellington_DW00100164",
                        IDDay = "LD004",
                        IDThuongHieu = "TH005",
                        IDNhaCungCap = "NC005",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4100000"),
                        HinhAnh = "/images/DATA/DanielWellington_DW00100164.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP053",
                        TenSanPham = "DanielWellington_DW00100277",
                        IDDay = "LD002",
                        IDThuongHieu = "TH005",
                        IDNhaCungCap = "NC005",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4600000"),
                        HinhAnh = "/images/DATA/DanielWellington_DW00100277.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP054",
                        TenSanPham = "DanielWellington_DW00100135",
                        IDDay = "LD001",
                        IDThuongHieu = "TH005",
                        IDNhaCungCap = "NC005",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5300000"),
                        HinhAnh = "/images/DATA/DanielWellington_DW00100135.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP055",
                        TenSanPham = "Candino_C45582",
                        IDDay = "LD001",
                        IDThuongHieu = "TH002",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5710000"),
                        HinhAnh = "/images/DATA/Candino_C42922.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP056",
                        TenSanPham = "Candino_C42922",
                        IDDay = "LD001",
                        IDThuongHieu = "TH002",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4650000"),
                        HinhAnh = "/images/DATA/Candino_C44714.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP057",
                        TenSanPham = "Candino_C44714",
                        IDDay = "LD001",
                        IDThuongHieu = "TH002",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5710000"),
                        HinhAnh = "/images/DATA/Candino_C46401.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP058",
                        TenSanPham = "Candino_C46401",
                        IDDay = "LD001",
                        IDThuongHieu = "TH002",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6750000"),
                        HinhAnh = "/images/DATA/Candino_C42921.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP059",
                        TenSanPham = "Candino_C42921",
                        IDDay = "LD001",
                        IDThuongHieu = "TH002",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4650000"),
                        HinhAnh = "/images/DATA/Saga_53229 SVMWSV-6.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP060",
                        TenSanPham = "Saga_53229 SVMWSV-6",
                        IDDay = "LD004",
                        IDThuongHieu = "TH012",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6384000"),
                        HinhAnh = "/images/DATA/Saga_80727 GPMWGP-2L.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP061",
                        TenSanPham = "Saga_80727 GPMWGP-2L",
                        IDDay = "LD004",
                        IDThuongHieu = "TH012",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6004000"),
                        HinhAnh = "/images/DATA/Saga_53555 SVMWSV-2.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP062",
                        TenSanPham = "Saga_53555 SVMWSV-2",
                        IDDay = "LD004",
                        IDThuongHieu = "TH012",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5244000"),
                        HinhAnh = "/images/DATA/Saga_71865 GPMWGP-2L.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP063",
                        TenSanPham = "Saga_71865 GPMWGP-2L",
                        IDDay = "LD004",
                        IDThuongHieu = "TH012",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6764000"),
                        HinhAnh = "/images/DATA/Saga_71865 GPMWGP-2L.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP064",
                        TenSanPham = "Saga_53624 RGBDBK-2",
                        IDDay = "LD004",
                        IDThuongHieu = "TH012",
                        IDNhaCungCap = "NC002",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6384000"),
                        HinhAnh = "/images/DATA/Saga_53624 RGBDBK-2.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP065",
                        TenSanPham = "Adriatica_A3694.51B3QZ",
                        IDDay = "LD004",
                        IDThuongHieu = "TH001",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("6210000"),
                        HinhAnh = "/images/DATA/Adriatica_A3694.51B3QZ.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP066",
                        TenSanPham = "Adriatica_A8109.5153Q",
                        IDDay = "LD004",
                        IDThuongHieu = "TH001",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("4440000"),
                        HinhAnh = "/images/DATA/Adriatica_A8109.5153Q.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP067",
                        TenSanPham = "Adriatica_A3603.5113QZ",
                        IDDay = "LD004",
                        IDThuongHieu = "TH001",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5490000"),
                        HinhAnh = "/images/DATA/Adriatica_A3603.5113QZ.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP068",
                        TenSanPham = "Adriatica_A3508.1143QZ",
                        IDDay = "LD004",
                        IDThuongHieu = "TH001",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5310000"),
                        HinhAnh = "/images/DATA/Adriatica_A3508.1143QZ.jpg"
                    },
                    new Domain.Entities.SanPham
                    {
                        IDSanPham = "SP069",
                        TenSanPham = "Adriatica_A3143.2111Q",
                        IDDay = "LD004",
                        IDThuongHieu = "TH001",
                        IDNhaCungCap = "NC004",
                        BaoHanh = "2 năm",
                        SoLuong = 10,
                        Gia = float.Parse("5610000"),
                        HinhAnh = "/images/DATA/Adriatica_A3143.2111Q.jpg"
                    }

                    );
                context.SaveChanges();

                //HoaDonNhap
                if (context.hoaDonNhap.Any()) return;
                context.hoaDonNhap.AddRange(
                    new Domain.Entities.HoaDonNhap
                    {
                        IDHoaDonNhap = "DN001",
                        IDNhaCungCap = "NC002",
                        ThanhTien = float.Parse("33022000"),
                        NgayNhap = DateTime.Parse("2020-02-20"),
                    },
                    new Domain.Entities.HoaDonNhap
                    {
                        IDHoaDonNhap = "DN002",
                        IDNhaCungCap = "NC004",
                        ThanhTien = float.Parse("51510000"),
                        NgayNhap = DateTime.Parse("2020-06-01"),
                    },
                    new Domain.Entities.HoaDonNhap
                    {
                        IDHoaDonNhap = "DN003",
                        IDNhaCungCap = "NC001",
                        ThanhTien = float.Parse("31092000"),
                        NgayNhap = DateTime.Parse("2020-06-29"),
                    },
                    new Domain.Entities.HoaDonNhap
                    {
                        IDHoaDonNhap = "DN004",
                        IDNhaCungCap = "NC005",
                        ThanhTien = float.Parse("29000000"),
                        NgayNhap = DateTime.Parse("2020-10-24"),
                    }
                    );
                context.SaveChanges();

                //HoaDonBan
                if (context.hoaDonBan.Any()) return;
                context.hoaDonBan.AddRange(
                    new Domain.Entities.HoaDonBan
                    {
                        IDHoaDonBan = "DB001",
                        IDKhachHang = "KH003",
                        ThanhTien = float.Parse("10000000"),
                        NgayBan = DateTime.Parse("2020-10-20"),
                        TrangThai = " "
                    },
                    new Domain.Entities.HoaDonBan
                    {
                        IDHoaDonBan = "DB002",
                        IDKhachHang = "KH005",
                        ThanhTien = float.Parse("4650000"),
                        NgayBan = DateTime.Parse("2020-11-20"),
                        TrangThai = " "
                    },
                    new Domain.Entities.HoaDonBan
                    {
                        IDHoaDonBan = "DB003",
                        IDKhachHang = "KH004",
                        ThanhTien = float.Parse("5710000"),
                        NgayBan = DateTime.Parse("2020-11-27"),
                        TrangThai = " "
                    }, 
                    new Domain.Entities.HoaDonBan
                    {
                        IDHoaDonBan = "DB004",
                        IDKhachHang = "KH001",
                        ThanhTien = float.Parse("9217000"),
                        NgayBan = DateTime.Parse("2020-12-01"),
                        TrangThai = " "
                    }
                    );
                context.SaveChanges();

                //ChiTietHoaDonBan
                if (context.chiTietHoaDonBan.Any()) return;
                context.chiTietHoaDonBan.AddRange(
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB001",
                        IDSanPham = "SP005",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB001",
                        IDSanPham = "SP044",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB002",
                        IDSanPham = "SP059",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB003",
                        IDSanPham = "SP055",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB004",
                        IDSanPham = "SP012",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB004",
                        IDSanPham = "SP034",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonBan
                    {
                        IDHoaDon = "DB004",
                        IDSanPham = "SP027",
                        SoLuong = 1
                    }
                    );
                context.SaveChanges();

                //ChiTietHoaDonNhap
                if (context.chiTietHoaDonNhap.Any()) return;
                context.chiTietHoaDonNhap.AddRange(
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN001",
                        IDSanPham = "SP025",
                        SoLuong = 2
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN001",
                        IDSanPham = "SP045",
                        SoLuong = 1
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN001",
                        IDSanPham = "SP060",
                        SoLuong = 3
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN002",
                        IDSanPham = "SP066",
                        SoLuong = 5
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN002",
                        IDSanPham = "SP058",
                        SoLuong = 4
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN003",
                        IDSanPham = "SP018",
                        SoLuong = 3
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN004",
                        IDSanPham = "SP050",
                        SoLuong = 2
                    },
                    new Domain.Entities.ChiTietHoaDonNhap
                    {
                        IDHoaDonNhap = "DN004",
                        IDSanPham = "SP053",
                        SoLuong = 4
                    }
                    );
                context.SaveChanges();

                
                
                
            }
        }
    }
}