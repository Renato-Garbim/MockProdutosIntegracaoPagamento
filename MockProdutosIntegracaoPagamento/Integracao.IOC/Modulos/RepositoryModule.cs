using Integracao.Mock.DB;
using Integracao.Mock.DB.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Integracao.IOC.Modulos
{
    public class RepositoryModule
    {
        public static void SetModules(IServiceCollection container)
        {
            container.AddScoped<IInfraMock, InfraMock>();

        }
    }
}
