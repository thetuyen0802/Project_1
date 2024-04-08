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

        DBContext _context;

        public ProductDetailRepo()
        {
            _context = new DBContext(); 

        }

        public bool Add(ProductDetail productDetail)
        {

            if (productDetail == null) return false;    
            _context.Add(productDetail);
            _context.SaveChanges(); 
            return true;    

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

           if(productDetail == null)

            {
                return false;
            }
            else
            {

                var obj = _context.ProductDetails.Find(productDetail.ProDetailId);
                obj.ProductId = productDetail.ProductId;    


                obj.CategoryId = productDetail.CategoryId;  
                obj.MaterialId = productDetail.MaterialId;  
                obj.ColorId = productDetail.ColorId;    
                obj.SizeId = productDetail.SizeId;  
                //////obj.Quantity = productDetail.Quantity;  
                //obj.Price = productDetail.Price;
                _context.Update(obj);   
                _context.SaveChanges(); 
                return true;    

            }
        }
    }
}
