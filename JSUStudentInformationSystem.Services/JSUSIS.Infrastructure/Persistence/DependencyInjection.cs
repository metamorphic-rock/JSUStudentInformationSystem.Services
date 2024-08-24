using JSUSIS.Infrastructure.Persistence.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace JSUSIS.Infrastructure.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection ImplementPersistance(this
        IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JSUSISDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),
            b => b.MigrationsAssembly(typeof(JSUSISDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<IJSUSISDbContext>(provider =>
                provider.GetService<IJSUSISDbContext>());

            return services;
        }
    }
}
