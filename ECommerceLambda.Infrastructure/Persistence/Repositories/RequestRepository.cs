using Amazon.DynamoDBv2.DataModel;
using EcommerceLambda.Domain.Entities.Request;

namespace ECommerceLambda.Infrastructure.Persistence.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly IDynamoDBContext _dynamoDBContext;

        public RequestRepository(IDynamoDBContext dynamoDBContext)
        {
            _dynamoDBContext = dynamoDBContext;
        }

        public async Task Save(Request request)
        {
            await _dynamoDBContext.SaveAsync(request);
        }
    }
}
