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
            if (nv == null) return false;
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
<<<<<<< HEAD
            if(nv == null)
=======
           if (nv == null)
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
            {
                return false;
            }
            else
            {
<<<<<<< HEAD
                var obj = _context.Employesses.Find(nv.EmployessId);
                obj.Name = nv.Name; 
                obj.Status = nv.Status; 
                obj.Email = nv.Email;   
                _context.Update(obj);
                _context.SaveChanges();
                return true;        
=======
                var temp = _context.Employesses.Find(nv.EmployessId);
                temp.Name = nv.Name;
                temp.Status = nv.Status;
                temp.Email = nv.Email;
                temp.UserId = nv.UserId;
                _context.Update(temp);
                _context.SaveChanges();
                return true;
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
            }
        }
    }
}
