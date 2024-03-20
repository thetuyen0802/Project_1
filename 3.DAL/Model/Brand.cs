using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Brand
    {

        public int BrandId { get; set; }

        public string? BrandName { get; set; }
        public List<ProductDetail>? ProductDetails{ get; set; }
    }
}
