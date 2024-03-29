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
    public class CustomerServices : ICustomerServices
    {
        private ICustomerRepo _customer;

        public CustomerServices()
        {
            _customer = new CustomerRepo();    
        }

        public string Add(Customer customer)
        {
            if (_customer.Add(customer))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<Customer> GetAll()
        {
            return _customer.GetAll();  
        }

        public Customer GetByID(int id)
        {
            return _customer.FindById(id);  
        }

        public string Update(Customer customer)
        {
            if (_customer.Update(customer))
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
