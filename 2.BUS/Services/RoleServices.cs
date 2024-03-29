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
    public class RoleServices : IRoleServices
    {
        private IRoleRepo _irolerepo;

        public RoleServices()
        {
            _irolerepo = new RoleRepo();   
        }

        public string Add(Role role)
        {
            if (_irolerepo.Add(role))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }         
            
        }

        public Role GetById(int id)
        {
            return _irolerepo.GetById(id);  
        }

        public List<Role> GetRoles()
        {
            return _irolerepo.GetAll();    
        }

        public string Update(Role role)
        {
            if (_irolerepo.Update(role))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
    }
}
