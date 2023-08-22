using UsuariosApp.Application.Interfaces.Producers;
using UsuariosApp.Application.Interfaces.Services;
using UsuariosApp.Application.Services;
using UsuariosApp.Domain.Interfaces.Repositories;
using UsuariosApp.Domain.Interfaces.Services;
using UsuariosApp.Domain.Services;
using UsuariosApp.Infra.Data.Contexts;
using UsuariosApp.Infra.Data.Repositories;
using UsuariosApp.Infra.Messages.Producers;
using UsuariosApp.Infra.Messages.Settings;

namespace UsuariosApp.Api.Extensions
{
    public static class ServicesExtesion
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MessageSettings>(configuration.GetSection("MessageSettings"));

            services.AddTransient<IUsuarioAppService, UsuarioAppService>();
            services.AddTransient<IUsuarioMessageProducer, UsuarioMessageProducer>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
