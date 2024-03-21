using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IProductRepository
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        Product FindById(int id);
        List<Product> GetAll();
    }
}
