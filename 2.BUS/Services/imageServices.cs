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
    public class imageServices : IimageServices
    {
        private IimageRepo _imageRepo;

        public imageServices()
        {
            _imageRepo = new imageRepo();
        }

        public string Add(Image ig)
        {
            if (_imageRepo.Add(ig))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public Image GetImageById(int id)
        {
           return _imageRepo.GetImage(id);  
        }

        public List<Image> GetImages()
        {
            return _imageRepo.GetImages();  
        }

        public string Update(Image ig)
        {
            if (_imageRepo.Update(ig))
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
