﻿using _2.BUS.IServices;
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
            _iBillRepository= new BilllRepository();
        }

        public string Delete(Bill bill)
        {
            if (bill == null) return "Xoá thất bại";
            else
            {

                _iBillRepository.Delete(bill);
                return "Xóa thành công";
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