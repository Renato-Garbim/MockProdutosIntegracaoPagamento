using Microsoft.Extensions.DependencyInjection;
using System;

namespace Integracao.IOC.Modulos
{
    public class ServiceModule
    {
        public static void SetModules(IServiceCollection container)
        {
            //container.AddScoped<IGameService, GameService>();
        }
    }
}
