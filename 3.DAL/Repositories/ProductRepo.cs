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
    public class ProductRepo : IProductRepo
    {
        DBContext _context;

        public ProductRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Product product)
        {

            if (product == null) return false;
            _context.Add(product);
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

            if(product == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Products.Find(product.ProductId);
                obj.ProductName = product.ProductName;  
                obj.QuantityExists = product.QuantityExists;    
                obj.Cost = product.Cost;    
                _context.Update(obj);   
                _context.SaveChanges(); 
                return true;    

            }
        }
    }
}
