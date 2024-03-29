using _2.BUS.IServices;
<<<<<<< HEAD
=======
using _3.DAL.IRepositories;
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
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
<<<<<<< HEAD
        private ProductDetailRepo _iproductrepo;

        public ProductDetailServices()
        {
            _iproductrepo = new ProductDetailRepo ();
        }

        public string Add(ProductDetail prd)
        {
            if(_iproductrepo.Add(prd))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
=======
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
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public ProductDetail FindById(int id)
        {
<<<<<<< HEAD
            return _iproductrepo.FindById(id);  
=======
            return _iProductDetailRepo.FindById(id);
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }

        public List<ProductDetail> GetAll()
        {
<<<<<<< HEAD
            return _iproductrepo.GetAll();
        }

        public string Update(ProductDetail prd)
        {
            if (_iproductrepo.Update(prd))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
=======
            return _iProductDetailRepo.GetAll().ToList();
        }

        public string Update(ProductDetail product)
        {
            if (_iProductDetailRepo.Update(product))
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật thất bại";
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        }
    }
}
