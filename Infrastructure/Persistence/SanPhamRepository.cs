using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SanPhamRepository : ISanPhamRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public SanPhamRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<SanPham> getAll(int pageIndex, int pageSize, string search, string Type, out int count)
        {
            var query = _conText.sanPham.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if (!string.IsNullOrEmpty(search))
            {
                if (Type == "TenSanPham")
                {
                    query = query.Where(m => m.TenSanPham.Contains(search));
                }
                else
                {
                    query = query.Where(m => m.IDSanPham.Contains(search));
                }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử sanPham có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
        public IEnumerable<SanPham> getAll()
        {
            return _conText.sanPham.ToList();
        }
        public SanPham GetSanPham(string maSanPham)
        {

            return _conText.sanPham.Find(maSanPham); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void SuaSanPham(SanPham sanPham)//hàm sửa vào database
        {
            _conText.sanPham.Update(sanPham);
            _conText.SaveChanges();
        }

        public void ThemSanPham(SanPham sanPham)//hàm thêm vào database
        {
            _conText.sanPham.Add(sanPham);
            _conText.SaveChanges();
        }

        public void XoaSanPham(string maSanPham)//xóa một đối tượng ở database
        {

            var sanPhamDaTimThay = _conText.sanPham.Find(maSanPham);
            _conText.sanPham.Remove(sanPhamDaTimThay);
            _conText.SaveChanges();

        }
        public IEnumerable<SanPham> getAll(int pageIndex, int pageSize, string textSearch, string type, bool price, out int count)
        {

            var query = _conText.sanPham.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if (!string.IsNullOrEmpty(textSearch))
            {
                query = query.Where(m => m.TenSanPham.Contains(textSearch));
            }
            if (!string.IsNullOrEmpty(type))
            {
                query = query.Where(m => m.IDThuongHieu.Contains(type));
            }
            if (!price)
            {
                query = query.OrderByDescending(s => s.Gia);
            }
            else
            {
                query = query.OrderBy(s => s.Gia);
            }
            count = query.Count();//Hàm Count dùng để dếm số lượng phần tử thuongHieu có trong context

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }
        public IEnumerable<SanPham> get4sp(int boqua)
        {
            var query = _conText.sanPham.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            return query.Skip(boqua).Take(8).ToList();
        }
        public SanPham Xemsp(string maSanPham)
        {

            return _conText.sanPham.Find(maSanPham); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }
    }
}
