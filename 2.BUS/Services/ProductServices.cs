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
        private IProductRepo _iProductRepo;

        public ProductServices()
        {
            _iProductRepo = new ProductRepo();
        }

        public string Add(Product product)
        {
            if (_iProductRepo.Add(product))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public Product FindById(int id)
        {
            return _iProductRepo.FindById(id);
        }

        public List<Product> GetAll()
        {
           return _iProductRepo.GetAll().ToList();
        }

        public string Update(Product product)
        {
            if (_iProductRepo.Update(product))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";

        }
    }
}
