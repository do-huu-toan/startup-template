using Microsoft.Extensions.DependencyInjection;
using Sample.Application.Services;
using Sample.Infratructure.Repositories;
using Sample.Infratructure.Services;
using System.Linq;

namespace Sample.Host.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigDI(this IServiceCollection services)
        {
            //DependencyInjection
            #region services
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            #endregion
            #region repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion
            return services;
        }
    }
}
