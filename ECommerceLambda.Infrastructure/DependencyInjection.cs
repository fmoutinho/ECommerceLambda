using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.SQS;
using EcommerceLambda.Domain.Entities.Client;
using ECommerceLambda.Application.Service;
using ECommerceLambda.Infrastructure.Persistence.Repositories;
using ECommerceLambda.Infrastructure.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceLambda.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddDynamoDBContext()
                .AddAmazonSQS()
                .AddRepositories()
                .AddServices();

            return services;
        }

        public static IServiceCollection AddDynamoDBContext(this IServiceCollection services)
        {
            services.AddScoped<IAmazonDynamoDB, AmazonDynamoDBClient>();
            services.AddScoped<IDynamoDBContext, DynamoDBContext>();
            return services;
        }

        public static IServiceCollection AddAmazonSQS(this IServiceCollection services)
        {
            services.AddScoped<IAmazonSQS, AmazonSQSClient>();
            services.AddScoped<IDynamoDBContext, DynamoDBContext>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRequestService, RequestService>();
            return services;
        }
    }
}
