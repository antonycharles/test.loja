using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Application.Handlers;
using Loja.Core.Handlers;
using Loja.Core.Repositories;
using Loja.Infrastructure.Repositories;

namespace Loja.Web.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository,UserRepository>();
            services.AddTransient<IProductRepository,ProductRepository>();

            services.AddTransient<IProductHandler, ProductHandler>();
        }
    }
}