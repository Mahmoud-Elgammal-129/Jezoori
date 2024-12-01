using Jezoori.Context;
using Microsoft.EntityFrameworkCore;

namespace Jezoori.Extensions
{
    public static class DBExtension
    {
        public static IServiceCollection AddDbContextConfig(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
