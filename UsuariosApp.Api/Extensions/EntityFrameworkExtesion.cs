using Microsoft.EntityFrameworkCore;
using UsuariosApp.Infra.Data.Contexts;

namespace UsuariosApp.Api.Extensions
{
    public static class EntityFrameworkExtesion
    {
        public static IServiceCollection AddEntityFrameWork(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("UsuariosApp");
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }

    }
}
