using _3.DAL.Context;
using _3.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class Colorrepo : IColorRepo
    {
        DBContext _context;

        public Colorrepo()
        {
            _context = new DBContext(); 
        }

        public bool Add(Model.Color color)
        {
            if(color == null)   return false;
            _context.Add(color);    
            _context.SaveChanges(); 
            return true;    
            
        }

        public Model.Color FindByID(int id)
        {
            return _context.Colors.Find(id);
        }

        public List<Model.Color> GetColors()
        {
            return _context.Colors.ToList();
        }

        public bool Update(Model.Color color)
        {
           if( color == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Colors.Find(color.ColorId);
                obj.ColorName = color.ColorName;    
                obj.ColorCode = color.ColorCode;    
                _context.Colors.Update(obj);
                _context.SaveChanges();
                return true;    
            }
            
        }
    }
}
