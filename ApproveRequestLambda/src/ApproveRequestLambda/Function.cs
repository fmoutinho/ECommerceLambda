using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using EcommerceLambda.Domain.Entities.Request;
using ECommerceLambda.Application;
using ECommerceLambda.Application.Abstractions;
using ECommerceLambda.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ApproveRequestLambda
{
    public class Function
    {
        private readonly IServiceProvider _serviceProvider;

        public Function()
        {
            InitFunction();
        }

        private void InitFunction()
        {
            var services = new ServiceCollection();

            services
                .AddApplication()
                .AddInfrastructure();
        }

        public async Task FunctionHandler(SQSEvent input, ILambdaContext context)
        {
            foreach (var message in input.Records)
            {
                await ProcessMessageAsync(message, context);
            }
        }

        private async Task ProcessMessageAsync(SQSEvent.SQSMessage message, ILambdaContext context)
        {
            context.Logger.LogLine($"Processed message {message.Body}");

            var requestService = _serviceProvider.GetRequiredService<IRequestService>();

            var request = JsonConvert.DeserializeObject<Request>(message.Body);

            await requestService.ApproveRequest(request);

            await Task.CompletedTask;
        }
    }
}
