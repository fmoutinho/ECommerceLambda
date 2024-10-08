using Amazon.DynamoDBv2.DataModel;
using EcommerceLambda.Domain.Entities.Client;

namespace ECommerceLambda.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDynamoDBContext _dynamoDBContext;

        public ClientRepository(IDynamoDBContext dynamoDBContext)
        {
            _dynamoDBContext = dynamoDBContext;
        }

        public async Task Create(Client client)
        {
            await _dynamoDBContext.SaveAsync<Client>(client);
        }

        public async Task Delete(string document)
        {
            await _dynamoDBContext.DeleteAsync<Client>(document);
        }

        public async Task<Client?> GetByDocument(string document)
        {
            return await _dynamoDBContext.LoadAsync<Client?>(document);
        }

        public async Task Update(Client client)
        {
            await _dynamoDBContext.SaveAsync<Client>(client);
        }
    }
}
