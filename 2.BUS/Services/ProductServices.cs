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
<<<<<<< HEAD
        private ProductRepository _product;

        public ProductServices()
        {
            _product = new ProductRepository();       
=======
        private IProductRepo _iProductRepo;

        public ProductServices()
        {
            _iProductRepo = new ProductRepo();
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public string Add(Product product)
        {
<<<<<<< HEAD
           if(_product.Add(product))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
=======
            if (_iProductRepo.Add(product))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public Product FindById(int id)
        {
<<<<<<< HEAD
            return _product.FindById(id);   
=======
            return _iProductRepo.FindById(id);
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public List<Product> GetAll()
        {
<<<<<<< HEAD
            return _product.GetAll();   
=======
           return _iProductRepo.GetAll().ToList();
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public string Update(Product product)
        {
<<<<<<< HEAD
            if (_product.Update(product))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
=======
            if (_iProductRepo.Update(product))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";

>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }
    }
}
