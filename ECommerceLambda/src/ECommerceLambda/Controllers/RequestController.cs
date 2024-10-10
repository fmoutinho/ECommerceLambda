using Microsoft.AspNetCore.Mvc;
using EcommerceLambda.Domain.Entities.Request;
using ECommerceLambda.Application.Abstractions;

namespace ECommerceLambda.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : Controller
    {
        private readonly ILogger<RequestController> _logger;
        private readonly IRequestService _requestService;

        public RequestController(ILogger<RequestController> logger, IRequestService requestService)
        {
            _logger = logger;
            _requestService = requestService;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] Request request)
        {
            await _requestService.SendRequest(request);
            return Ok();
        }
    }
}
