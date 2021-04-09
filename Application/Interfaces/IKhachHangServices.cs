using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IKhachHangServices
    {
        public void themKhachHang(KhachHangDTO khachHang);

        public void suaKhachHang(KhachHangDTO khachHang);

        public void xoaKhachHang(string maKhachHang);

        public KhachHangDTO GetKhachHang(string maKhachHang);

        IEnumerable<KhachHangDTO> getAll(int pageIndex, int pageSize, string search, string Type, out int count);

        IEnumerable<KhachHangDTO> getAll();
    }
}
