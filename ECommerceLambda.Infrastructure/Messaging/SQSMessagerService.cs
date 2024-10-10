using Amazon.SQS;
using Amazon.SQS.Model;
using EcommerceLambda.Domain.Entities.Request;
using ECommerceLambda.Application.Abstractions;
using System.Text.Json;

namespace ECommerceLambda.Infrastructure.Service
{
    public class SQSMessagerService : IMessager
    {
        private readonly IAmazonSQS _amazonSQS;
        public SQSMessagerService(IAmazonSQS amazonSQS)
        {
            _amazonSQS = amazonSQS;
        }

        public async Task Produce(Request request)
        {
            var messageRequest = new SendMessageRequest
            {
                MessageBody = JsonSerializer.Serialize(request),
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/453076547823/created-request-sqs"
            };
            await _amazonSQS.SendMessageAsync(messageRequest);
        }
    }
}
