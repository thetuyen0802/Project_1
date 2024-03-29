﻿using _3.DAL.Context;
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
<<<<<<< HEAD:3.DAL/Repositories/ProductRepository.cs
            if (product == null) return false;
            _context.Add(product);
            _context.SaveChanges(); 
            return true;    
        }
=======
            //if (product == null) { return false; }
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }

       
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d:3.DAL/Repositories/ProductRepo.cs

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
<<<<<<< HEAD:3.DAL/Repositories/ProductRepository.cs
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
=======
            if (product == null)
            {
                return false;
            }
            else 
            {
                var temp = _context.Products.Find(product.ProductId);
                temp.ProductName=product.ProductName;
                temp.QuantityExists=product.QuantityExists;
                temp.Cost=product.Cost;
                _context.Update(product);
                _context.SaveChanges();
                return true;
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d:3.DAL/Repositories/ProductRepo.cs
            }
        }
    }
}
