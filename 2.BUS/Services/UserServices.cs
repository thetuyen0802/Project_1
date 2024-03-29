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
    public class UserServices : IUserServices
    {
        IUserRepo _userrepo;

        public UserServices()
        {
            _userrepo = new UserRepo();
        }

        public string AddUser(User user)
        {
           if(_userrepo.Add(user))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public User GetById(int id)
        {
           return _userrepo.FindById(id);
        }

        public List<User> GetUsers()
        {
            return _userrepo.GetAll();
        }

        public string Update(User user)
        {
            if (_userrepo.Update(user))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
    }
}
