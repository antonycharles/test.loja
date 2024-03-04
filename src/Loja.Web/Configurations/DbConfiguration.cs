using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Loja.Web.Configurations
{
    public static class DbConfiguration
    {
        public static void AddDataBase(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("WebApiDatabase");
            builder.Services.AddDbContext<LojaContext>(options => {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.UseMySql(
                    connectionString,
                    new MySqlServerVersion(new Version(8, 3, 0)));   
            });
        }

        public static void AddMigration(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                var logger = loggerFactory.CreateLogger<Program>();

                try
                {
                    var db = services.GetRequiredService<LojaContext>();
                    db.Database.Migrate();
                }
                catch (Exception exception)
                {
                    logger.LogError(exception, "An error occurred migration the DB.");
                }
            }
        }

        public static void SeedData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<LojaContext>();
                
            }
        }
    }
}