using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Application.Abstrations;
using Users.Domain.Models;

namespace Users.Infrastructure.Persistance
{
    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<UserModel> Users { get; set; }
    }
}
