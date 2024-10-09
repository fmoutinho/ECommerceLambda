using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ApproveRequestLambda
{
    public class Function
    {
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

            await Task.CompletedTask;
        }
    }
}
