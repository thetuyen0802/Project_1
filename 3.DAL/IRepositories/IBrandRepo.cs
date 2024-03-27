using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IBrandRepo
    {
        bool Add(Brand brand);
        bool Update(Brand brand);   
        List<Brand> GetAll();
        Brand FindById(int id);

    }
}
