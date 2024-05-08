using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Application.Abstrations;
using Users.Infrastructure.Persistance;

namespace Users.Infrastructure
{
    public static class UserInfrastructureDependencyInjection
    {
        public static IServiceCollection AddUserInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration) 
        { 
          services.AddDbContext<IUsersDbContext, UsersDbContext>(options =>
          {
              options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
              
          });
          return services;
         
        }
    }
}
