using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IEventRepo
    {
        bool Add(Event ev);
        bool Update(Event ev);  
        List<Event> GetEvents();    
        Event GetEventByID(int id);
    }
}
