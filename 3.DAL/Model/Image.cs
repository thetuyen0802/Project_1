using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Image
    {   
        public int ImageId { get; set; }
        public string ImageLink { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
    }
}
