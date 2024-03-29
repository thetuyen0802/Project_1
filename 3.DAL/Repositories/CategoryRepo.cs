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
<<<<<<< HEAD
        DBContext _context;

        public CategoryRepo()
        {
            _context = new DBContext(); 
        }

        public bool Add(Category category)
        {
           if(category == null)
            return false;
           _context.Add(category);  
            _context.SaveChanges();
            return true;
=======
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
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public List<Category> GetAll()
        {
<<<<<<< HEAD
            return _context.Categories.ToList();   
=======
            return _context.Categories.ToList();
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public bool Update(Category category)
        {
<<<<<<< HEAD
            if (category == null)
            {
                return false;
            }
            else
            {
                var tem = _context.Brands.Find(category.CategoryId);
                tem.BrandName = category.CategoryName;
                _context.Brands.Update(tem);
                _context.SaveChanges();
                return true;
            }
    }

=======
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
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
