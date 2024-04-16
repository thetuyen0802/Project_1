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
    public class Bill_ProductDetailsServices : IBill_ProductDetailsServices
    {
        private IBill_ProductDetailRepo _bill_product_repo;

        public Bill_ProductDetailsServices()
        {
            _bill_product_repo = new Bill_ProductRepo();    
        }

        public string Add(Bill_ProductDetail bill_pro_details)
        {
            if (_bill_product_repo.Add(bill_pro_details))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<Bill_ProductDetail> GetAll()
        {
            return _bill_product_repo.GetAll();
        }

        public string Update(Bill_ProductDetail obj)
        {
            if (_bill_product_repo.Update(obj))
            {
                return "Cập nhật thành công";
            }
            else
            {
                return "Cập nhậtthất bại";
            }
        }
    }
}
