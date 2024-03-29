using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IProductDetailServices
    {
        string Add(ProductDetail prd);
        string  Update(ProductDetail prd);
        ProductDetail FindById(int id);
        List<ProductDetail> GetAll();
    }
}
