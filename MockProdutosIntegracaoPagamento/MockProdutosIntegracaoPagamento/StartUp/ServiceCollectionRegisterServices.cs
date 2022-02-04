using Integracao.IOC;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MockProdutosIntegracaoPagamento.StartUp
{
    public static class ServiceCollectionRegisterServices
    {

        public static IServiceCollection StartRegisterServices(this IServiceCollection services)
        {
            
            IntegracaoBootstrapper.RegisterServices(services);

            //var defaultContainer = services.BuildServiceProvider();

            return services;
        }

    }
}
