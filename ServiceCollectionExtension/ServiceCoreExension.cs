using Microsoft.Extensions.DependencyInjection;
using UpWork.API;
using UpWork.Application.Services;
using UpWork.Core.Interfaces.Services;
using UpWork.Infrastructure.Repositories;

namespace ISDN.RST.Engine.ServiceCollectionExtension
{
    public static class ServiceCoreExension
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddScoped<ValidateModelStateFilter>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IClientUserRepository, ClientRepository>();
            services.AddScoped<ClientRepository>();
            return services;
        }
    }
}
