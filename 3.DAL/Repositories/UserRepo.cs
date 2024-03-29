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
            if(nd == null) return false;
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
<<<<<<< HEAD
           if( nd == null)
=======
            if (nd == null)
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
            {
                return false;
            }
            else
            {
<<<<<<< HEAD
                var obj = _context.Users.Find(nd.UserId);
                obj.RoleId = nd.RoleId; 
                obj.UserName = nd.UserName; 
                obj.Email = nd.Email;   
                obj.Password = nd.Password; 
                obj.Status = nd.Status; 
                _context.Update(obj);   
                _context.SaveChanges(); 
                return true;    


=======
                var temp = _context.Users.Find(nd.UserId);
                temp.UserName=nd.UserName;
                temp.RoleId=nd.RoleId;
                temp.Password=nd.Password;
                temp.Email=nd.Email;
                temp.Status=nd.Status;
                _context.Update(temp);
                _context.SaveChanges();
                return true;
>>>>>>> 147599f48a840a7b22d22aac364befbe205b883d
            }
        }
    }
}
