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
    public class ProductRepository : IProductRepository
    {
        DBContext _context;

        public ProductRepository()
        {
            _context = new DBContext();
        }

        public bool Add(Product product)
        {
            //if (product == null) { return false; }
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Product product)
        {

            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;

        }

        public Product FindById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public bool Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return true;
        }
    }
}
