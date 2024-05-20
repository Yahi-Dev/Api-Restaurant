using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.Application.Interfaces.Services;
using Restaurant.Core.Application.NewFolder;
using Restaurant.Core.Application.Services;
using System.Reflection;

namespace Restaurant.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<IPlatoService, PlatoService >();
            services.AddTransient<IOrdenService, OrdenService>();
            services.AddTransient<IMesaService, MesaService>();
            services.AddTransient<IIngredienteService, IngredienteService>();
            services.AddTransient<IUserService, UserService>();
            #endregion
        }
    }
}
