using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Event
    {
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string? EventFormat { get; set; }
        public string? Decription { get; set; }
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        public List<Event_Product>? Event_Products { get; set; }
    }
}
