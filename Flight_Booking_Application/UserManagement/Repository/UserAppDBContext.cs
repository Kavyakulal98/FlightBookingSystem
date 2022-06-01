using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Model;

namespace UserManagement.Repository
{
    public class UserAppDBContext:DbContext
    {
        public UserAppDBContext(DbContextOptions<UserAppDBContext> options) : base(options)
        {

        }
        public DbSet<User> UserDetails { get; set; }
        
    }
}
