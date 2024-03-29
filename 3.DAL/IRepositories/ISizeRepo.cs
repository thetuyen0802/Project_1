using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface ISizeRepo
    {
        bool Add(Size size);    
        bool Update(Size size); 
        List<Size> GetAll();    
        Size GetById(int id);  
    }
}
