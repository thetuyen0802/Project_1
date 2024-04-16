using _3.DAL.Context;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class EmployessRepo : IEmployessRepo
    {
        private DBContext _context;

        public EmployessRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Employess nv)
        {
            if (nv == null)
            {
                return false;
            }
            else
            {
                _context.Add(nv);
                _context.SaveChanges();
                return true;
            }
           
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

            if(nv == null)

            {
                return false;
            }
            else
            {

                var obj = _context.Employesses.Find(nv.EmployessId);
                obj.Name = nv.Name; 
                obj.Status = nv.Status; 
                obj.Email = nv.Email;   
                _context.Update(obj);
                _context.SaveChanges();
                return true;        

            }
        }
    }
}
