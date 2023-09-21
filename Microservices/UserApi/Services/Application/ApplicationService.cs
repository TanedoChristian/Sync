using Microsoft.EntityFrameworkCore;
using UserApi.Data;

namespace UserApi.Services.Application
{
    public static class ApplicationService
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
           

            return services;
        }

        public static IServiceCollection AddDataContextServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddAutoMapperServices(this IServiceCollection services)
        {
          
            return services;
        }
    }
}
