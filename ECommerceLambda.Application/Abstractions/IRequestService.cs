using EcommerceLambda.Domain.Entities.Request;

namespace ECommerceLambda.Application.Abstractions
{
    public interface IRequestService
    {
        Task ApproveRequest(Request? request);
        Task SendRequest(Request? request);
    }
}
