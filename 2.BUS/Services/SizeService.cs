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
    public class SizeService : ISizeService
    {
        private SizeRepo _repo;

        public SizeService()
        {
            _repo = new SizeRepo(); 
        }

        public string Add(Size size)
        {
            if (_repo.Add(size))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public Size GetById(int id)
        {
            return _repo.GetById(id);       
        }

        public List<Size> GetSizes()
        {
           return _repo.GetAll();  
        }

        public string update(Size size)
        {
            if (_repo.Update(size))
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
