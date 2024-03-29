using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IimageServices
    {
        string Add(Image ig);
        string Update(Image ig);    
        List<Image> GetImages();
        Image GetImageById(int id); 
    }
}
