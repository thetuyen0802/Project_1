using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IMaterialRepo
    {
        bool Add(Material material);
        bool Update(Material material); 
        List<Material> GetAll();
        Material GetById(int id);   
    }
}
