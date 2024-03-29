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
    public class imageRepo : IimageRepo
    {
        DBContext _context;

        public imageRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Image image)
        {
            if (image == null) return false;
            _context.Add(image);
            _context.SaveChanges(); 
            return true;        
        }

        public Image GetImage(int id)
        {
            return _context.Images.Find(id);
        }

        public List<Image> GetImages()
        {
            return _context.Images.ToList();    
        }

        public bool Update(Image image)
        {
           if(image == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Images.Find(image.ImageId);
                obj.ImageLink = image.ImageLink;    
                _context.Update(obj);
                _context.SaveChanges(); 
                return true;    
            }
        }
    }
}
