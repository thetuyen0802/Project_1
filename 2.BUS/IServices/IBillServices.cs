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
<<<<<<< HEAD
        string Add(Bill bill);
=======
        string (Bill bill);
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        string Update(Bill bill);
        Bill FindById(int id);
        List<Bill> GetAll();
    }
}
