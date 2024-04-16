using _3.DAL.Context;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class Bill_ProductRepo : IBill_ProductDetailRepo
    {
        private DBContext _context;

        public Bill_ProductRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Bill_ProductDetail obj)
        {
            if (obj == null) { return false; }
            else
            {
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
        }
        
        public List<Bill_ProductDetail> GetAll()
        {
            return _context.Bill_ProductDetails.ToList();
        }

        public bool Update(Bill_ProductDetail obj)
        {
            if (obj==null)
            {
                return false;
            }
            else
            {
                Bill_ProductDetail bill_ProductDetail = _context.Bill_ProductDetails.FirstOrDefault(c => c.BillId == obj.BillId && c.ProDetailId == obj.ProDetailId);
                bill_ProductDetail.Price= obj.Price;
                bill_ProductDetail.Quantity= obj.Quantity;
               _context.Update(bill_ProductDetail);
                _context.SaveChanges();
                return true;
            }
           

        }
    }
}
