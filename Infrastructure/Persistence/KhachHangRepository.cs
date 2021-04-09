using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class KhachHangRepository : IKhachHangRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public KhachHangRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<KhachHang> getAll(int pageIndex, int pageSize, string search, string Type, out int count)
        {
            var query = _conText.khachHang.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if (!string.IsNullOrEmpty(search))
            {
                if (Type == "TenKhachHang")
                {
                    query = query.Where(m => m.TenKhachHang.Contains(search));
                }
                else if (Type == "SoDienThoai")
                    {
                    query = query.Where(m => m.SoDienThoai.Contains(search));
                    }
                else
                    {
                        query = query.Where(m => m.IDKhachHang.Contains(search));
                    }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử khachHang có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
        public IEnumerable<KhachHang> getAll()
        {
            return _conText.khachHang.ToList();
        }
        public KhachHang GetKhachHang(string maKhachHang)
        {

            return _conText.khachHang.Find(maKhachHang); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void SuaKhachHang(KhachHang khachHang)//hàm sửa vào database
        {
            _conText.khachHang.Update(khachHang);
            _conText.SaveChanges();
        }

        public void ThemKhachHang(KhachHang khachHang)//hàm thêm vào database
        {
            _conText.khachHang.Add(khachHang);
            _conText.SaveChanges();
        }

        public void XoaKhachHang(string maKhachHang)//xóa một đối tượng ở database
        {

            var khachHangDaTimThay = _conText.khachHang.Find(maKhachHang);
            _conText.khachHang.Remove(khachHangDaTimThay);
            _conText.SaveChanges();

        }
    }
}
