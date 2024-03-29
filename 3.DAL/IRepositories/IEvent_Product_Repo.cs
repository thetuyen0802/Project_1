using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IEvent_Product_Repo
    {
        bool Add(Event_Product event_Product);
        bool Update(Event_Product event_Product);
        List<Event_Product> GetAll();
        Event_Product GetById(int id);      
    }
}
