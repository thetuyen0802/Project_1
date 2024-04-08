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
    public class CategogyServices : ICategogyServices
    {
        private ICategoryRepo _categogy;

        public CategogyServices()
        {
            _categogy = new CategoryRepo();
        }

        public string Add(Category categogy)
        {
            if (_categogy.Add(categogy))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public Category GetByID(int id)
        {
            return _categogy.GetById(id);   
        }

        public List<Category> GetCategories()
        {
            return _categogy.GetAll();
        }

        public string Update(Category categogy)
        {
            if (_categogy.Update(categogy))
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
