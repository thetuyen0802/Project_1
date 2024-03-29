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
    public class EmployessServices : IEmployessServices
    {
        private IEmployessRepo _employessRepo;

        public EmployessServices()
        {
            _employessRepo = new EmployessRepo();
        }

        public string Add(Employess employess)
        {
            if (_employessRepo.Add(employess))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<Employess> GetAll()
        {
            return _employessRepo.GetAll(); 
        }

        public Employess GetById(int id)
        {
            return _employessRepo.FindById(id); 
        }

        public string Update(Employess employess)
        {
            if (_employessRepo.Update(employess))
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
