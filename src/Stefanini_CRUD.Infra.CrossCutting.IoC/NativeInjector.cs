using Stefanini_CRUD.Application.Stefanini_CRUDService.Service;
using Stefanini_CRUD.Infra.CrossCutting.IoC.Settings;
using Stefanini_CRUD.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Stefanini_CRUD.Infra.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void AddLocalHttpClients(this IServiceCollection services )
        {

        }
        // public static void Setup(IServiceCollection services, IConfiguration configuration)
        // {
        //     RegisterServices(services, configuration);
        // }

        // private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        // {
        //     services.AddScoped<IPersonService, PersonService>();
        //     services.AddScoped<ICityService, CityService>();
        // }
    }
}
