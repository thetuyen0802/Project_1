using _2.BUS.IServices;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using _3.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class EventServices : IEventServices
    {
        private IEventRepo _event;

        public EventServices()
        {
            _event = new EventRepo();   
        }

        public string Add(Event eve)
        {
            if (_event.Add(eve))
            {
                return "Thêm thành công";
            }
            else
            {
                return " Thêm thất bại";
            }
        }

        public Event GetByID(int id)
        {
           return _event.GetEventByID(id);
        }

        public List<Event> GetEvents()
        {
            return _event.GetEvents();
        }

        public string Update(Event eve)
        {
            if (_event.Update(eve))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
        }
    }
}
