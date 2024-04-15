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
            _iBillRepository = new BilllRepo();
        }


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


        public List<Bill> GetAll()
        {
            return _iBillRepository.GetAll();
        }

        public string Update(Bill bill)
        {
            if (_iBillRepository.Update(bill)) return "Update thành công";
            else return "Update thất bại";
        }
    }
}
