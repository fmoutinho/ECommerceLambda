using EcommerceLambda.Domain.Entities.Request;

namespace ECommerceLambda.Application.Service
{
    public interface IRequestService
    {
        Task SendRequest(Request request);
    }
}
