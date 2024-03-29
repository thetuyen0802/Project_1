using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IRoleRepo
    {
        bool Add(Role role);    
        bool Update(Role role); 
        List<Role> GetAll();    
        Role GetById(int id);   
    }
}
