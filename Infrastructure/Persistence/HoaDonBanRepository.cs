using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class HoaDonBanRepository : IHoaDonBanRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public HoaDonBanRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }
        //Viết chức năng ở đây, xem mẫu ở SanPhamRepository.cs
        public IEnumerable<HoaDonBan> getAll(int pageIndex, int pageSize,string search,string Type,float Tien,out int count)
        {
            var query = _conText.hoaDonBan.AsQueryable();//Trả về kiểu tương tự như list nhưng sẽ dùng các phương thức lọc nhanh hơn ( cái này t không rõ lắm - Nguyên)
            if(!string.IsNullOrEmpty(search))
            { 
                if(Type=="IDHoaDonBan"){          
                    query=query.Where(m => m.IDHoaDonBan.Contains(search));
                }
                else
                {
                     query=query.Where(m => m.IDKhachHang.Contains(search));
                }
            }
            if(Tien!=0){
                if(Tien==1){
                    query=query.Where(m => m.ThanhTien<=1000000);
                }
                else if(Tien==2){
                    query=query.Where(m => m.ThanhTien>1000000);
                    query=query.Where(m => m.ThanhTien<=5000000);
                }
                else
                {
                    query=query.Where(m => m.ThanhTien>5000000);
                }
            }
            //Gán giá trị cho biến count để truyền giá trị về
            count=query.Count();//Hàm Count dùng để dếm số lượng phần tử HoaDonBan có trong context
            return query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();//Skip là bỏ qua n phần tử đầu , take là chỉ lấy m phần tử 
        }
    }
}
