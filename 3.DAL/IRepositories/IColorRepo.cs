using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IColorRepo
    {
        bool Add(Color color);`
        bool Update (Color color);  
        List<Color> GetColors();    
        Color FindByID (int id);
    }
}
