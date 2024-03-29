using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBrandServices
    {
        string Add(Brand brand);        
        string Update(Brand brand); 
        List<Brand> GetAll();   
        Brand GetById(int id);      
    }
}
