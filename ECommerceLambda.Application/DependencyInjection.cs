using ECommerceLambda.Application.Abstractions;
using ECommerceLambda.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceLambda.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IRequestService, RequestService>();
            return services;
        }
    }
}
