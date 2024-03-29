using _3.DAL.Context;
using _3.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class Event_Product_Repo : IEvent_Product_Repo
    {
        DBContext _context;

        public Event_Product_Repo()
        {
            _context = new DBContext(); 
        }

        public bool Add(Model.Event_Product event_Product)
        {
            if(event_Product == null) return false;
            _context.Add(event_Product);
            _context.SaveChanges();
            return true;
        }

        public List<Model.Event_Product> GetAll()
        {
            return _context.Event_Products.ToList();    
        }

        public Model.Event_Product GetById(int id)
        {
            return _context.Event_Products.Find(id);
        }

        public bool Update(Model.Event_Product event_Product)
        {
            if (event_Product == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Event_Products.Find(event_Product.EventId);
                obj.Event = event_Product.Event;
                obj.Product = event_Product.Product;
                _context.Event_Products.Update(obj);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
