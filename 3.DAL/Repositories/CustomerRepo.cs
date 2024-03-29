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
    public class CustomerRepo : ICustomerRepo
    {
        private DBContext _context;

        public CustomerRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Customer kh)
        {
          if(kh == null)    return false;
            _context.Customers.Add(kh);
            _context.SaveChanges();
            return true;
        }

        
        public Customer FindById(int id)
        {
            return _context.Customers.Find(id);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public bool Update(Customer kh)
        {

      
            if (kh==null)

            {
                return false;
            }
            else
            {

                var obj = _context.Customers.Find(kh.CustomerId);
               obj.Name = kh.Name;  
                obj.Status = kh.Status; 
                obj.PhoneNumber = kh.PhoneNumber;   
                _context.Update(obj);
                _context.SaveChanges();
                return true;

            }

        }
    }

}