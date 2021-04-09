using System;
using System.Collections.Generic;
namespace mvcDongHo.ViewModels
{
    public class PaginatedList<T> : List<T>//class này dùng để phân trang
    {
        public PaginatedList(IEnumerable<T> items, int count, int pageIndex, int pageSize)
        {
            this.AddRange(items);//Thêm mảng items 
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);//Tính tổng số trang được phân dựa trên số lượng trên 1 trang ( page Size )
        }

        public int PageIndex { get; }
        public int TotalPages { get; }

        public bool HasPreviousPage { get => PageIndex > 1; }//hàm này dùng để xem trang trước đó có lớn hơn 1 không
        public bool HasNextPage { get => PageIndex < TotalPages; }//Hàm này dùng để xem trang sau đó có lớn hơn tổng trang hay không 
    }
}
