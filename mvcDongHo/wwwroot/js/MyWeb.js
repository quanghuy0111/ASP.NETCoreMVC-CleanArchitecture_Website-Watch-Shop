 //Hàm xóa thương hiệu
 //viết jquery, do xài cái model để xác nhận có muốn xóa hay không thì mình không lấy mã trực tiếp như cái sửa được nên phải viết thêm cái này  
$("button#xoathuonghieu").click(function ()
//  tạo sự kiên click cho cái button ở trên theo cú pháp của jquery: "tenthe#mã thẻ" 
{
    var id = $(this).data("id");//gán IDThuongHieu đã được lưu vào data-id ở trên để gán vào biến id
    var obj = '<a class="btn btn-success" href="https://localhost:5001/Admin/QuanLiThuongHieu/XoaThuongHieuData/' + id + '">Có</a>'
        + '<button type="button" class="btn btn-secondary" data-dismiss="modal">Không</button>';//tạo biến obj để lưu lại cái html mình cần xuất ra, cái này tui không quá rõ nhưng mà cứ làm theo thôi, hok khó
    $("div#footer-del").html(obj);//gọi cái thẻ div có mã là footer-del để chèn phần html zo
});
$('button#xemchitietban').click(function ()
{
    var id = $(this).data("id");
    console.log(id);
    $.ajax({
        type:"GET",
        url:"/Admin/QuanLiHoaDonBan/HoaDonBan",
        data:{IDHoaDon:id},
        success:function(response){
            console.log(response)
            $('tbody#content').empty();
            response.forEach(function(item) {
                var obj='<tr>'
                        +'<td>'+item.idSanPham+'</td>'
                        +'<td>'+item.soLuong+'</td>'
                        +'</tr>';
                $('tbody#content').append(obj);
            });
            
        }
    });   
});
$('button#xemchitietnhap').click(function ()
{
    var id = $(this).data("id");
    console.log(id);
    $.ajax({
        type:"GET",
        url:"/Admin/QuanLiHoaDonNhap/HoaDonNhap",
        data:{IDHoaDonNhap:id},
        success:function(response){
            console.log(response)
            $('tbody#content').empty();
            response.forEach(function(item) {
                var obj='<tr>'
                            +'<td>'+item.idSanPham+'</td>'
                            +'<td>'+item.soLuong+'</td>'
                        +'</tr>';
                $('tbody#content').append(obj);
            });
            
        }
    });   
});
<<<<<<< HEAD

    
=======
>>>>>>> master
