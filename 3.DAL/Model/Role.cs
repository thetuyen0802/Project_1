using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DAL.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }

    ///Một role chi nhiều nhân viên
        public List<User>? Users { get; set; }
  
    }
}
