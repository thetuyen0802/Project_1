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
    public class ProductDetailServices : IProductDetailServices
    {
        private IProductDetailRepo _iProductDetailRepo;

        public ProductDetailServices()
        {
            _iProductDetailRepo = new ProductDetailRepo();
        }

        public string Add(ProductDetail product)
        {
            if (_iProductDetailRepo.Add(product))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public ProductDetail FindById(int id)
        {
            return _iProductDetailRepo.FindById(id);
        }

        public List<ProductDetail> GetAll()
        {
            return _iProductDetailRepo.GetAll().ToList();
        }

        public string Update(ProductDetail product)
        {
            if (_iProductDetailRepo.Update(product))
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật thất bại";
        }
    }
}
