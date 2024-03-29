using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IEvent_ProductServices
    {
        string Add(Event_Product eve_pro);
        string Update(Event_Product eve_pro);   
        List<Event_Product> GetEventProduct();  
        Event_Product GetByID(int id);  

    }
}
