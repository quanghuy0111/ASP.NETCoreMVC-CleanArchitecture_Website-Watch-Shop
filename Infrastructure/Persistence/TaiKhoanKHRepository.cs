using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class TaiKhoanKHRepository : ITaiKhoanKHRepository
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public TaiKhoanKHRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<TaiKhoanKH> getAll(int pageIndex, int pageSize, string search, string Type, out int count)
        {
            var query = _conText.taiKhoanKH.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if (!string.IsNullOrEmpty(search))
            {
                if (Type == "IDKhacHang")
                {
                    query = query.Where(m => m.IDKhachHang.Contains(search));
                }
                else
                {
                    query = query.Where(m => m.TaiKhoan.Contains(search));
                }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử taiKhoanKH có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
        public TaiKhoanKH GetTaiKhoanKH(string maTaiKhoanKH)
        {

            return _conText.taiKhoanKH.Find(maTaiKhoanKH); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void ThemTaiKhoanKH(TaiKhoanKH taiKhoanKH)//hàm thêm vào database
        {
            _conText.taiKhoanKH.Add(taiKhoanKH);
            _conText.SaveChanges();
        }

        public void XoaTaiKhoanKH(string maTaiKhoanKH)//xóa một đối tượng ở database
        {

            var taiKhoanKHDaTimThay = _conText.taiKhoanKH.Find(maTaiKhoanKH);
            _conText.taiKhoanKH.Remove(taiKhoanKHDaTimThay);
            _conText.SaveChanges();

        }
        public IEnumerable<TaiKhoanKH> getAll()
        {
            var listTaiKhoan = _conText.taiKhoanKH.ToList();
            return listTaiKhoan;
        }
        public TaiKhoanKH TimTK(string TaiKhoan, string MatKhau, string IDKhachHang)
        {

            return _conText.taiKhoanKH.Find(TaiKhoan, MatKhau, IDKhachHang); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }
        public void ThemTK(TaiKhoanKH taiKhoanKH)//hàm thêm vào database
        {
            _conText.taiKhoanKH.Add(taiKhoanKH);
            _conText.SaveChanges();
        }

    }
}
