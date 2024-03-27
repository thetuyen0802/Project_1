using _3.DAL.Context;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class BrandRepo : IBrandRepo
    {
        private DBContext _context;

        public BrandRepo()
        {
            _context = new DBContext();
        }

        public bool Add(Brand brand)
        {
            if (brand == null) return false;
            _context.Add(brand);
            _context.SaveChanges();
            return true;

        }

        public Brand FindById(int id)
        {
            return _context.Brands.Find(id);
        }

        public List<Brand> GetAll()
        {
            return _context.Brands.ToList();
        }

        public bool Update(Brand brand)
        {
            if (brand==null)
            {
                return false;
            }
            else
            {
                var tem= _context.Brands.Find(brand.BrandId);
                tem.BrandName=brand.BrandName;
                _context.Brands.Update(tem);
                _context.SaveChanges();
                return true;
            }

        }
    }
}
