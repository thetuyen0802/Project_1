using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IColorServices
    {
        string Add(Color color);
        string  Update(Color color);    
        List<Color> GetColors();    
        Color GetByID(int id);  
    }
}
