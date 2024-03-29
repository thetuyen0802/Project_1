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
    public class MaterialServices : IMaterialServices
    {
        private IMaterialRepo _materialRepo;

        public MaterialServices()
        {
            _materialRepo = new MaterialRepo(); 
        }

        public string Add(Material material)
        {
            if (_materialRepo.Add(material))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public Material Get(int id)
        {
            return _materialRepo.GetById(id);   
        }

        public List<Material> GetAll()
        {
            return _materialRepo.GetAll();      
        }

        public string Update(Material material)
        {
            if (_materialRepo.Update(material))
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
