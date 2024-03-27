using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface ICategoryRepo
    {
        bool Add(Category category);
        bool Update(Category category);
        Category GetById(int id);
        List<Category> GetAll();

    }
}
