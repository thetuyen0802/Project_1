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
    internal class EmployessRepo : IEmployessRepo
    {
        private DBContext _context;

        public EmployessRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Employess nv)
        {
            _context.Add(nv);   
            _context.SaveChanges(); 
            return true;
        }

       

        public Employess FindById(int id)
        {
            return _context.Employesses.Find(id);
        }

        public List<Employess> GetAll()
        {
           return _context.Employesses.ToList();    
        }

        public bool Update(Employess nv)
        {
            _context.Update(nv);
            _context.SaveChanges();
            return true;
        }
    }
}
