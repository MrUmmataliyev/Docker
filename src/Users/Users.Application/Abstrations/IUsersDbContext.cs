using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain.Models;

namespace Users.Application.Abstrations
{
    public interface IUsersDbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
