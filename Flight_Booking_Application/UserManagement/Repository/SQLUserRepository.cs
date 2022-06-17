using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Model;

namespace UserManagement.Repository
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly UserAppDBContext context;
        public SQLUserRepository(UserAppDBContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<User> GetUser()
        {      
                return context.UserDetails;
  
        }

        public User GetUserbyUserId(int userId)
        {
                return context.UserDetails.Find(userId);
        }
        public async Task<User> Login(string username, string password)
        {
            return await context.UserDetails.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }
        //public UserDetails Login(string username, string password)
        //{
           
        //        var query = context.UserDetails.Where(a => a.UserName == username && a.Password == password);
        //    if(query != null)
        //    {
        //        return query.SingleOrDefault();
        //    }
        //    else
        //    {
        //        return new UserDetails();
        //    }
                
          

        //}

        public bool RegisterUser(User user)
        {
            User existinguser = new User();
            existinguser=context.UserDetails.Where(m => m.EmailAddress == user.EmailAddress).SingleOrDefault();
            if (existinguser != null){
                return false;
            }
            else
            {
                context.UserDetails.Add(user);
                context.SaveChanges();
                //return user;
                return true;
            }
               
         

        }
    }
}
