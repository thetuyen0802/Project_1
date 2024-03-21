using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.IRepositories
{
    public interface IBillRepository
    {
        bool Add(Bill bill);
        bool Update(Bill bill);
        bool Delete(Bill bill);
        Bill FindById(int id);
        List<Bill> GetAll();

    }
}
