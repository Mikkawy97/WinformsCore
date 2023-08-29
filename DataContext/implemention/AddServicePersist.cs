using DataContext.Context;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.implemention
{
    public static class AddServicePersist
    {
    
            public static IServiceCollection GetServices(this IServiceCollection services)
        {
            services.AddDbContext<CompanyContext>(ServiceLifetime.Singleton, ServiceLifetime.Singleton);
            services.AddScoped<IUnitofwork, UnitofWork>();
            return services;    
        }

    }
}
