using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public List<Bill> Bills { get; set; }
        public User User { get; set; }
    }
}
