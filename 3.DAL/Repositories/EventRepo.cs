using _3.DAL.Context;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class EventRepo : IEventRepo
    {
        DBContext _context;

        public EventRepo()
        {
            _context = new DBContext(); 
        }

        public bool Add(Event ev)
        {
            if(ev == null) return false;    
            _context.Add(ev);   
            _context.SaveChanges(); 
            return true;    
        }

        public Event GetEventByID(int id)
        {
            return _context.Events.Find(id);
        }

        public List<Event> GetEvents()
        {
            return _context.Events.ToList();
        }

        public bool Update(Event ev)
        {
           if(ev == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Events.Find(ev.EventId);
                obj.EventName = ev.EventName;   
                obj.EventFormat = ev.EventFormat;   
                obj.DayStart = ev.DayStart; 
                obj.DayEnd = ev.DayEnd; 
                _context.Update(obj);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
