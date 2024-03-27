using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IProductDetailServices
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        Product FindById(int id);
        List<Product> GetAll();
    }
}
