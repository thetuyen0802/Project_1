using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IEmployess
    {
        bool Add(Employess nv);
        bool Update(Employess nv);
        bool Delete(Employess nv);
        Employess FindByID ( int id);   
        List<Employess> GetAllfromDb();
    }
}
