using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IProductServices
    {
        string Add(Product product);
        string Update(Product product);
        Product FindById(int id);
        List<Product> GetAll();
    }
}
