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
    public class BilllRepo : IBillRepository
    {
        private DBContext _context;

        public BilllRepo()
        {
            _context = new DBContext();
        }

            public bool Add(Bill bill)
            {
                if (bill == null)
                {
                    return false;
                }
                else
                {
                    _context.Bills.Add(bill);
                    _context.SaveChanges();
                    return true;
                }
            
          
            }

        public bool Delete(Bill bill)
        {
            _context.Bills.Remove(bill);
            _context.SaveChanges();
            return true;
        }

        public Bill FindById(int id)
        {
            //if (id == null)
            //{
            //    return ;
            //}
            //else { return _context.Bills.Find(id); }
            return _context.Bills.Find(id);
        }

        public List<Bill> GetAll()
        {
            return _context.Bills.ToList();
        }

        public bool Update(Bill bill)
        {
            if (bill==null)
            {
                return false ;
            }
            else
            {
                Bill temp = _context.Bills.Find(bill.BillId);
                temp.CreateDate = bill.CreateDate;
                temp.PaymenDate = bill.PaymenDate;
                temp.EmployessId = bill.EmployessId;
                temp.CustomerId = bill.CustomerId;
                temp.Status = bill.Status;
                _context.Bills.Update(temp);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
