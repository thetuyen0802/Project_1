using _2.BUS.IServices;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using _3.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ColorServices : IColorServices
    {
        private IColorRepo _color;

        public ColorServices()
        {
            _color = new Colorrepo();
        }

        public string Add(Color color)
        {
            if (_color.Add(color))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public Color GetByID(int id)
        {
            return _color.FindByID(id);
        }

        public List<Color> GetColors()
        {
           return _color.GetColors();       
        }

        public string Update(Color color)
        {
            if (_color.Update(color))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
        }
    }
}
