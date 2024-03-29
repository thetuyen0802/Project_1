using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICategogyServices
    {
        string Add(Category categogy);
        string Update(Category categogy);   
        List<Category> GetCategories();
        Category GetByID(int id);

    }
}
