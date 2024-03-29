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
    public class Event_ProductServices : IEvent_ProductServices
    {
        private IEvent_Product_Repo _evntPro;

        public Event_ProductServices()
        {
            _evntPro = new Event_Product_Repo();
        }

        public string Add(Event_Product eve_pro)
        {
            if (_evntPro.Add(eve_pro))
            {
                return "Thêm thành công";
            }
            else
            {
                return " Thêm thất bại";
            }
        }

        public Event_Product GetByID(int id)
        {
            return _evntPro.GetById(id);    
        }

        public List<Event_Product> GetEventProduct()
        {
            return _evntPro.GetAll();   
        }

        public string Update(Event_Product eve_pro)
        {
            if (_evntPro.Update(eve_pro))
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
