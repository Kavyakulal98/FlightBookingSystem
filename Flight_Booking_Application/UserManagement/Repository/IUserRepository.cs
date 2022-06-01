using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Model;

namespace UserManagement.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUser();

        User GetUserbyUserId(int userId);

       Task<User> Login(string username, string password);

        User RegisterUser(User user);

        
    }
}
