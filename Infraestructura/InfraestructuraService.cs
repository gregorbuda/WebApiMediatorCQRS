using Aplicacion.Persistencia;
using Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public static class InfraestructuraService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DataBaseDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
            );

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<ISolicitudRepository, SolicitudRepository>();

            return services;
        }
    }
}
