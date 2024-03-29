using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IEventServices
    {
        string Add(Event eve);
        string Update(Event eve);   
        List<Event> GetEvents();    
        Event GetByID(int id);  
    }
}
