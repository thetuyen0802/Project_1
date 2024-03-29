using _2.BUS.IServices;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using _3.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class BrandServices : IBrandServices
    {
        private IBrandRepo _brand;

        public BrandServices()
        {
            _brand = new BrandRepo();   
        }

        public string Add(Brand brand)
        {
            if (_brand.Add(brand))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<Brand> GetAll()
        {
            return _brand.GetAll(); 
        }

        public Brand GetById(int id)
        {
            return _brand.FindById(id); 
        }

        public string Update(Brand brand)
        {
            if (_brand.Update(brand))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
        }
    }
}
