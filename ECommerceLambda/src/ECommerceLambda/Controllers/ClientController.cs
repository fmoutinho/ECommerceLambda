using EcommerceLambda.Domain.Entities.Client;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceLambda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> CreateClient(Client client)
        {
            return Ok();
        }
        [HttpGet("{document}")]
        public async Task<IActionResult> GetClientByDocument(string document)
        {
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateClient(Client client)
        {
            return Ok();
        }
        [HttpDelete("{document}")]
        public async Task<IActionResult> DeleteClient(string document)
        {
            return Ok();
        }
    }
}
