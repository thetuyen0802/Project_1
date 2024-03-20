using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Event_Product
    {
        public int EventId { get; set; }
        public int ProductId { get; set; }

        public Event? Event { get; set; }
        public Product? Product { get; set; }
            
    }
}
