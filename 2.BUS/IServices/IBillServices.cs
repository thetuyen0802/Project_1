using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBillServices
    {
        string Add(Bill bill);
        string Update(Bill bill);
        Bill FindById(int id);
        List<Bill> GetAll();
    }
}
