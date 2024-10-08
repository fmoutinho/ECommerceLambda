using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using EcommerceLambda.Domain.Entities.Client;
using ECommerceLambda.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceLambda.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddDynamoDBContext()
                .AddRepositories();

            return services;
        }

        public static IServiceCollection AddDynamoDBContext(this IServiceCollection services)
        {
            services.AddScoped<IAmazonDynamoDB, AmazonDynamoDBClient>();
            services.AddScoped<IDynamoDBContext, DynamoDBContext>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }
    }
}
