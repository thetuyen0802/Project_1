using _2.BUS.IServices;
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
        }

        public ProductDetail FindById(int id)
        {
            return _iproductrepo.FindById(id);  
        }

        public List<ProductDetail> GetAll()
        {
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
        }
    }
}
