using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ChiTietHoaDonNhapRepository : IChiTietHoaDonNhapRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public ChiTietHoaDonNhapRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }
        //Viết chức năng ở đây, xem mẫu ở SanPhamRepository.cs
        public IEnumerable<ChiTietHoaDonNhap> getAll()
        {
            return _conText.chiTietHoaDonNhap.ToList();
        }
    }
}
