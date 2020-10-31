using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NathannJShop.Core.Interfaces.Installer;
using NathannJShop.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Installers
{
    public class ProductoRepositoryInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ProductoRepository>();
        }
    }
}
