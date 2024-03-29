using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IUserServices
    {
        string AddUser(User user);
        string Update(User user);       
        List<User> GetUsers();  
        User GetById(int id);   
    }
}
