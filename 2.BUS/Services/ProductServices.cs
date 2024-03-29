using _2.BUS.IServices;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using _3.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ProductServices : IProductServices
    {

        private IProductRepo _product;

        public ProductServices()
        {
            _product = new ProductRepo();       

        }

        public string Add(Product product)
        {

           if(_product.Add(product))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }

        }

        public Product FindById(int id)
        {

            return _product.FindById(id);   

        }

        public List<Product> GetAll()
        {

            return _product.GetAll();   

        }

        public string Update(Product product)
        {

            if (_product.Update(product))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }

        }
    }
}
