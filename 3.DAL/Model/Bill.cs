using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Bill
    {
        public int BillId { get; set; }

        public int ProDetailId { get; set; }
        public int EmployessId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime PaymenDate { get; set; }
        public int Status { get; set; }
        
        public List<ProductDetail> ProductDetails { get; set; }
       
        public Employess Employess { get; set; }
        public Customer Customer { get; set; }
    }
}
