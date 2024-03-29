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
    public class ProductDetailRepo : IProductDetailRepo
    {
<<<<<<< HEAD
        DBContext _context;

        public ProductDetailRepo()
        {
            _context = new DBContext(); 
=======
        private DBContext _context;

        public ProductDetailRepo()
        {
            _context = new DBContext();
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public bool Add(ProductDetail productDetail)
        {
<<<<<<< HEAD
            if (productDetail == null) return false;    
            _context.Add(productDetail);
            _context.SaveChanges(); 
            return true;    
=======
            if (productDetail== null)
            {
                return false;   
            }
            else
            {
                _context.ProductDetails.Add(productDetail);
                _context.SaveChanges();
                return true;
            }
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public ProductDetail FindById(int id)
        {
            return _context.ProductDetails.Find(id);
        }

        public List<ProductDetail> GetAll()
        {
            return _context.ProductDetails.ToList();
        }

        public bool Update(ProductDetail productDetail)
        {
<<<<<<< HEAD
           if(productDetail == null)
=======
            if (productDetail== null)
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
            {
                return false;
            }
            else
            {
<<<<<<< HEAD
                var obj = _context.ProductDetails.Find(productDetail.ProDetailId);
                obj.ProductId = productDetail.ProductId;    
                obj.ImageId = productDetail.ImageId;    
                obj.BrandId = productDetail.BrandId;    
                obj.CategoryId = productDetail.CategoryId;  
                obj.MaterialId = productDetail.MaterialId;  
                obj.ColorId = productDetail.ColorId;    
                obj.SizeId = productDetail.SizeId;  
                obj.Quantity = productDetail.Quantity;  
                obj.Price = productDetail.Price;
                _context.Update(obj);   
                _context.SaveChanges(); 
                return true;    
=======
        
                var  temp= _context.ProductDetails.Find(productDetail.ProDetailId);
                temp.ProductId = productDetail.ProductId;
                temp.ImageId = productDetail.ImageId;
                temp.BrandId = productDetail.BrandId;
                temp.CategoryId = productDetail.CategoryId;
                temp.MaterialId = productDetail.MaterialId;
                temp.ColorId = productDetail.ColorId;
                temp.SizeId = productDetail.SizeId; 
                temp.Quantity = productDetail.Quantity;
                temp.Price = productDetail.Price;
                _context.ProductDetails.Update(temp);
                _context.SaveChanges();
                return true;
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
            }
        }
    }
}
