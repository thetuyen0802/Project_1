using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public  interface IUserRepo
    {
        bool Add(User nd);
        bool Update(User nd);   
        bool Delete(User nd);
        User FindById(int id);
        List<User> GetAll();
    }
}
