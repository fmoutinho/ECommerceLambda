using ECommerceLambda.Application.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceLambda.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
