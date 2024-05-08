using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Users.Application
{
    public static class UserApplicationDependencyInjection
    {
        public static IServiceCollection AddUserApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
