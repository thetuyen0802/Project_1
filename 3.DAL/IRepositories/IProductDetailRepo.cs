using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IProductDetailRepo
    {
        bool Add(ProductDetail productDetail);
        bool Update(ProductDetail productDetail);
        List<ProductDetail> GetAll();
        ProductDetail FindById(int id);
        
    }
}
