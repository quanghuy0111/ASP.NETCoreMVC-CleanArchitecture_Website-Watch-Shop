using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class NhaCungCapRepository : INhaCungCapRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public NhaCungCapRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<NhaCungCap> getAll(int pageIndex, int pageSize, string search, string Type, out int count)
        {
            var query = _conText.nhaCungCap.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if (!string.IsNullOrEmpty(search))
            {
                if (Type == "TenNhacungCap")
                {
                    query = query.Where(m => m.TenNhacungCap.Contains(search));
                }
                else if (Type == "SoDienThoai")
                {
                    query = query.Where(m => m.SoDienThoai.Contains(search));
                }
                else
                {
                    query = query.Where(m => m.IDNhaCungCap.Contains(search));
                }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử nhaCungCap có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
        public IEnumerable<NhaCungCap> getAll()
        {
            return _conText.nhaCungCap.ToList();
        }
        public NhaCungCap GetNhaCungCap(string maNhaCungCap)
        {

            return _conText.nhaCungCap.Find(maNhaCungCap); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void SuaNhaCungCap(NhaCungCap nhaCungCap)//hàm sửa vào database
        {
            _conText.nhaCungCap.Update(nhaCungCap);
            _conText.SaveChanges();
        }

        public void ThemNhaCungCap(NhaCungCap nhaCungCap)//hàm thêm vào database
        {
            _conText.nhaCungCap.Add(nhaCungCap);
            _conText.SaveChanges();
        }

        public void XoaNhaCungCap(string maNhaCungCap)//xóa một đối tượng ở database
        {

            var nhaCungCapDaTimThay = _conText.nhaCungCap.Find(maNhaCungCap);
            _conText.nhaCungCap.Remove(nhaCungCapDaTimThay);
            _conText.SaveChanges();

        }
    }
}
