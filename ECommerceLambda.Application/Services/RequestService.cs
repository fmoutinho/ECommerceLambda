using EcommerceLambda.Domain.Entities.Request;
using ECommerceLambda.Application.Abstractions;

namespace ECommerceLambda.Application.Services
{
    public class RequestService : IRequestService
    {
        private readonly IMessager _messager;
        private readonly IRequestRepository _requestRepository;

        public RequestService(IMessager messager, IRequestRepository requestRepository)
        {
            _messager = messager;
            _requestRepository = requestRepository;
        }

        public async Task ApproveRequest(Request? request)
        {
            if (request is not null)
            {
                await _requestRepository.Save(request);
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
