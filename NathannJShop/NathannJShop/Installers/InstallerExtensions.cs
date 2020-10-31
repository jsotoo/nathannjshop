using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NathannJShop.Core.Interfaces.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NathannJShop.Installers
{
    public static class InstallerExtensions
    {
        public static void InstallServiceAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly
             .ExportedTypes.Where(x =>
             typeof(IInstaller).IsAssignableFrom(x) && !x.IsAbstract)
             .Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

            installers.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
