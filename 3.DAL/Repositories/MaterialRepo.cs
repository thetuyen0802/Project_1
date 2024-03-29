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
    public class MaterialRepo : IMaterialRepo
    {
        DBContext _context;

        public MaterialRepo()
        {
            _context = new DBContext();     
        }

        public bool Add(Material material)
        {
            if(material == null) return false;  
            _context.Add(material); 
            _context.SaveChanges(); 
            return true;    
        }

        public List<Material> GetAll()
        {
           return _context.Materials.ToList();  
        }

        public Material GetById(int id)
        {
            return _context.Materials.Find(id);
        }

        public bool Update(Material material)
        {
            if(material == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Materials.Find(material.MaterialId);
                obj.MaterialName = material.MaterialName;   
                _context.Update(obj);
                _context.SaveChanges();
                return true;    
            }
        }
    }
}
