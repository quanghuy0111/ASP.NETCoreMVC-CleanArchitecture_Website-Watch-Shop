using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ThuongHieuRepository : IThuongHieuRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public ThuongHieuRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<ThuongHieu> getAll(int pageIndex, int pageSize,string search,string Type,out int count)
        {
            var query = _conText.thuongHieu.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if(!string.IsNullOrEmpty(search))
            { 
                if(Type=="TenThuongHieu")
                {          
                    query=query.Where(m => m.TenThuongHieu.Contains(search));
                }
                else 
                {
                    query=query.Where(m => m.IDThuongHieu.Contains(search));
                }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count=query.Count();//Hàm Count dùng để dếm số lượng phần tử thuongHieu có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
        public IEnumerable<ThuongHieu> getAll()
        {
            return _conText.thuongHieu.ToList();
        }
        public ThuongHieu GetThuongHieu(string maThuongHieu)
        {

            return _conText.thuongHieu.Find(maThuongHieu); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void SuaThuongHieu(ThuongHieu thuongHieu)//hàm sửa vào database
        {
            _conText.thuongHieu.Update(thuongHieu);
            _conText.SaveChanges();
        }

        public void ThemThuongHieu(ThuongHieu thuongHieu)//hàm thêm vào database
        {
            _conText.thuongHieu.Add(thuongHieu);
            _conText.SaveChanges();
        }

        public void XoaThuongHieu(string maThuongHieu)//xóa một đối tượng ở database
        {
            
            var thuongHieuDaTimThay = _conText.thuongHieu.Find(maThuongHieu);
            _conText.thuongHieu.Remove(thuongHieuDaTimThay);
            _conText.SaveChanges();

        }
    }
}
