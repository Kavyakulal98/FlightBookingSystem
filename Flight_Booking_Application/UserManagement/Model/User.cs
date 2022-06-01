using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public int ContactNumber { get; set; }
        public string Password { get; set; }
        public  int Age { get; set; }

    }
}
