using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public List<ProductDetail>?   ProductDetails { get; set; }
    }
}
