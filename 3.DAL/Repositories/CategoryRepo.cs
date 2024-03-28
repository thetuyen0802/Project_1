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
    public class CategoryRepo : ICategoryRepo
    {
        private DBContext _context;
        public bool Add(Category category)
        {
            if (category == null) return false;
            else
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return true;
            }
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public bool Update(Category category)
        {
            if (category==null)
            {
                return false;
            }
            else 
            {
                var temp = _context.Categories.Find(category.CategoryId);
                temp.CategoryName=category.CategoryName;
                _context.Categories.Update(category);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
