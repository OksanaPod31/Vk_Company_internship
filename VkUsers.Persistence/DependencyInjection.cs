using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkUsers.Application.Interfaces;

namespace VkUsers.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<UserDbContext>(options => { options.UseNpgsql(connectionString, b => b.MigrationsAssembly("VkUsers.WebApi")); });
            services.AddScoped<IUserDbContext>(provider => provider.GetService<UserDbContext>());
            return services;
        }
    }
}
