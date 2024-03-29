using _2.BUS.IServices;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using _3.DAL.Repositories;

namespace _2.BUS.Services
{
    public class BillServices : IBillServices
    {
        private IBillRepository _iBillRepository;
        public BillServices()
        {
            _iBillRepository = new BilllRepository();
        }

<<<<<<< HEAD
        public string Add(Bill bill)
        {
            if (_iBillRepository.Add(bill))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public Bill FindById(int id)
        {
            return _iBillRepository.FindById(id);
        }

=======
        public Bill FindById(int id)
        {
            return _iBillRepository.FindById(id);
        }

>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        public List<Bill> GetAll()
        {
            return _iBillRepository.GetAll();
        }
<<<<<<< HEAD

=======
        public string Add(Bill bill)
        {
            if (_iBillRepository.Add(bill)) return "Thêm thành công";
            else return "Thêm thất bại";
        }
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
        public string Update(Bill bill)
        {
            if (_iBillRepository.Update(bill)) return "Update thành công";
            else return "Update thất bại";
        }
    }
}
