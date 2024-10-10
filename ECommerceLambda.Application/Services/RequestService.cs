using EcommerceLambda.Domain.Entities.Request;
using ECommerceLambda.Application.Abstractions;

namespace ECommerceLambda.Application.Services
{
    public class RequestService : IRequestService
    {
        private readonly IMessager _messager;

        public RequestService(IMessager messager)
        {
            _messager = messager;
        }

        public async Task ApproveRequest(Request? request)
        {
            if (request is not null)
            {

            }
        }

        public async Task SendRequest(Request? request)
        {
            if (request is not null)
            {
                await _messager.Produce(request);
            }


        }
    }
}
