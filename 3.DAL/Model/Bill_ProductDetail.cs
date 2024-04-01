using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Bill_ProductDetail
    {
        public int BillId { get; set; }
        public int? ProDetailId { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public Bill? Bill { get; set; }
    }
}
