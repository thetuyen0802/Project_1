using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICustomerServices
    {
        string Add(Customer customer);
        string Update(Customer customer);   
        List<Customer> GetAll();    
        Customer GetByID(int id);
    }
}
