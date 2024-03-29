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
<<<<<<< HEAD
        string Add(ProductDetail prd);
        string  Update(ProductDetail prd);
=======
        string Add(ProductDetail product);
        string Update(ProductDetail product);
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        ProductDetail FindById(int id);
        List<ProductDetail> GetAll();
    }
}
