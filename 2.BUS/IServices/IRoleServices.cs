using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IRoleServices
    {
        string Add(Role role);  
        string Update(Role role);   
        List<Role> GetRoles();  
        Role GetById(int id);   
    }
}
