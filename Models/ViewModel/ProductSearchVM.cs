using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace laptrinhweb.Models.ViewModel
{
    public class ProductSearchVM
    {
        //tiêu chí để search theo tên, mô tả sp 
        // hoặc loại sản phẩm 
        public string SearchTerm { get; set; }
        public List<Product> Products { get; set; }
        // các tiêu chí  để search theo giá 
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        // thứ tự sắp xếp 
        public string SortOder {  get; set; }
         // các thuộc tính hỗ trợ phân trang 
         public int PageNumber { get; set; }   // trang hiện tại 
        public int PageSize { get; set; } = 10; // số sản phẩm mỗi trang 
        // danh sách sản phẩm đã phân trang 
       
    }
}