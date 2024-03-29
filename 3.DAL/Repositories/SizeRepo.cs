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
    public class SizeRepo : ISizeRepo
    {
        DBContext _context;

        public SizeRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Size size)
        {
            if(size == null) return false;  
            _context.Add(size); 
            _context.SaveChanges(); 
            return true;    
        }

        public List<Size> GetAll()
        {
            return _context.Sizes.ToList(); 
        }

        public Size GetById(int id)
        {
            return _context.Sizes.Find(id);
        }

        public bool Update(Size size)
        {
           if (size == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Sizes.Find(size.SizeId);
                obj.SizeName = size.SizeName;   
                _context.Update(obj);   
                _context.SaveChanges(); 
                return true;    
            }
        }
    }
}
