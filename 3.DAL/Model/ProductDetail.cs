using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class ProductDetail
    {
        public int ProDetailId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int MaterialId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public List<Bill_ProductDetail>? Bill_ProductDetail { get; set; }
        public Product? Product { get; set; }
        public Color? Color { get; set; }
        public Size? Size { get; set; }
        public Category? Category { get; set; }
        public Material? Material { get; set; }

    }
}
