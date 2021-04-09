using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using mvcDongHo.ViewModels;

namespace mvcDongHo.ViewModels
{
    public class CartItem
    {
        public SanPhamDTO sanPhamDTO { get; set; }

        public int quantityItem { get; set; }
    }
}
