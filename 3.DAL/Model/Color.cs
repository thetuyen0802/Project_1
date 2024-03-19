using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
       
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
    }
}
