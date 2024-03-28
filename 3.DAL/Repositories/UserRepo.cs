using _3.DAL.Context;
using _3.DAL.IRepositories;
using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Repositories
{
    public class UserRepo : IUserRepo
    {
        private DBContext _context;

        public UserRepo()
        {
            _context = new DBContext(); 
        }

        public bool Add(User nd)
        {
            _context.Add(nd);
            _context.SaveChanges();
            return true;
        }

        public User FindById(int id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetAll()
        {
           return _context.Users.ToList();
        }

        public bool Update(User nd)
        {
            if (nd == null)
            {
                return false;
            }
            else
            {
                var temp = _context.Users.Find(nd.UserId);
                temp.UserName=nd.UserName;
                temp.RoleId=nd.RoleId;
                temp.Password=nd.Password;
                temp.Email=nd.Email;
                temp.Status=nd.Status;
                _context.Update(temp);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
