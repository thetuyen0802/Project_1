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
    public class Bill_ProductDetailRepository : IBillRepository
    {
        private DBContext _context;

        public Bill_ProductDetailRepository(DBContext context)
        {
            _context = context;
        }

        public bool Add(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Bill bill)
        {
            _context.Bills.Remove(bill);
            _context.SaveChanges();
            return true;
        }

        public Bill FindById(int id)
        {
            return _context.Bills.Find(id);
        }

        public List<Bill> GetAll()
        {
            return _context.Bills.ToList();
        }

        public bool Update(Bill bill)
        {
            _context.Bills.Update(bill);
            _context.SaveChanges(true);
            return true;
        }
    }
}
