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
    public class RoleRepo : IRoleRepo
    {
        DBContext _context;

        public RoleRepo()
        {
            _context = new DBContext(); 
        }

        public bool Add(Role role)
        {
            if(role == null) return false;  
            _context.Add(role); 
            _context.SaveChanges();     
            return true;    
        }

        public List<Role> GetAll()
        {
            return _context.Roles.ToList(); 
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(id);
        }

        public bool Update(Role role)
        {
            if (role == null)
            {
                return false;
            }
            else
            {
                var obj = _context.Roles.Find(role.RoleId);
                obj.RoleName = role.RoleName;   
                _context.Update(obj);       
                _context.SaveChanges(); 
                return true;    
            }
        }
    }
}
