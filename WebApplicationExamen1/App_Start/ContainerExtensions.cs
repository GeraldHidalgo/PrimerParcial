using DB;
using WBL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationExamen1
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<IDepartamentoService, DepartamentoService>();
            services.AddTransient<ITituloService, TituloService>();
            services.AddTransient<IPuestoService, PuestoService>();
            return services;
        }
    }
}
