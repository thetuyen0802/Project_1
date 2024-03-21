using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface ICustomer
    {
        bool Add(Customer kh);
        bool Update(Customer kh);   
        bool Delete(Customer kh);
        Customer FindByID (int id);
        List<Customer> GetAllfromDb();    
    }
}
