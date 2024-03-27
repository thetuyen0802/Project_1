using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IEmployessRepo
    {
        bool Add(Employess nv);
        bool Update(Employess nv);
        Employess FindById ( int id);   
        List<Employess> GetAll();
    }
}
