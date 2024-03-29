using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IEmployessServices
    {
        string Add(Employess employess);
        string Update (Employess employess);        
        List<Employess> GetAll();   
        Employess GetById(int id);  
    }
}
