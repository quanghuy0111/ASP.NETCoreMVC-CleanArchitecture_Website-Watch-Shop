using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class LoaiDayRepository : ILoaiDayRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public LoaiDayRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<LoaiDay> getAll(int pageIndex, int pageSize, string search, string Type, out int count)
        {
            var query = _conText.loaiDay.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if (!string.IsNullOrEmpty(search))
            {
                if (Type == "TenLoaiDay")
                {
                    query = query.Where(m => m.TenLoaiDay.Contains(search));
                }
                else
                {
                    query = query.Where(m => m.IDDay.Contains(search));
                }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử loaiDay có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
        public IEnumerable<LoaiDay> getAll()
        {
            return _conText.loaiDay.ToList();
        }
        public LoaiDay GetLoaiDay(string maLoaiDay)
        {

            return _conText.loaiDay.Find(maLoaiDay); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void SuaLoaiDay(LoaiDay loaiDay)//hàm sửa vào database
        {
            _conText.loaiDay.Update(loaiDay);
            _conText.SaveChanges();
        }

        public void ThemLoaiDay(LoaiDay loaiDay)//hàm thêm vào database
        {
            _conText.loaiDay.Add(loaiDay);
            _conText.SaveChanges();
        }

        public void XoaLoaiDay(string maLoaiDay)//xóa một đối tượng ở database
        {

            var loaiDayDaTimThay = _conText.loaiDay.Find(maLoaiDay);
            _conText.loaiDay.Remove(loaiDayDaTimThay);
            _conText.SaveChanges();

        }
    }
}
