using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class User
    {

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; } 

        // Một nhân viên có 1 role
        public Role Role { get; set; }

        public List<Employess> Employesses { get; set; }
        public List<Customer> Customers { get; set;}
    }
}
