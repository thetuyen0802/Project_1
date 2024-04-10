using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Size
    {
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public List<ProductDetail>? ProductDetails { get; set; }
    }
}
