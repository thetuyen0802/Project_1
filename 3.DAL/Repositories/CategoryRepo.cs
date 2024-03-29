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

