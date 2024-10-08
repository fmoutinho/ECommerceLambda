namespace EcommerceLambda.Domain.Entities.Client
{
    public interface IClientRepository
    {
        Task Create(Client client);
        Task Update(Client client);
        Task Delete(string document);
        Task<Client?> GetByDocument(string document);
    }
}
