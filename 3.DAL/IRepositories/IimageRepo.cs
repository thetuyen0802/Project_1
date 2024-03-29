using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IimageRepo
    {
        bool Add(Image image);  
        bool Update(Image image);  
        List<Image> GetImages();
        Image GetImage(int id);
    }
}
