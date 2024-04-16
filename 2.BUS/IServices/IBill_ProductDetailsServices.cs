using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBill_ProductDetailsServices
    {
        string Add(Bill_ProductDetail bill_pro_details);
        //string Update(Bill_ProductDetail bill_pro_detail);
        List<Bill_ProductDetail> GetAll();

        string Update(Bill_ProductDetail obj);

    }
}
