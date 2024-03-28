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
        private DBContext _context;

        public ProductDetailRepo()
        {
            _context = new DBContext();
        }

        public bool Add(ProductDetail productDetail)
        {
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
            if (productDetail== null)
            {
                return false;
            }
            else
            {
        
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
            }
        }
    }
}
