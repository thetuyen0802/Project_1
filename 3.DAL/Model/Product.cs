using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string? ProductName { get; set; }
        public int QuantityExists { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }    
        public int Status { get; set; }
        public Brand? Brand { get; set; }
        public List<ProductDetail>? ProductDetails { get; set;}
        public List<Event_Product>? Event_Products { get; set;}

    }
}
