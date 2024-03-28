using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IProductRepo
    {
        bool Add(Product product);
        bool Update(Product product);
        Product FindById(int id);
        List<Product> GetAll();
    }
}
