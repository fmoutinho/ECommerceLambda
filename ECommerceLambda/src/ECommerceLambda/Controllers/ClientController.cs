using EcommerceLambda.Domain.Entities.Client;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceLambda.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientRepository _clientRepository;

        public ClientController(ILogger<ClientController> logger, IClientRepository clientRepository)
        {
            _logger = logger;
            _clientRepository = clientRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            await _clientRepository.Create(client);
            return Ok();
        }

        [HttpGet("{document}")]
        public async Task<IActionResult> GetByDocument(string document)
        {
            var client = await _clientRepository.GetByDocument(document);
            
            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Client client)
        {
            await _clientRepository.Update(client);
            return Ok();
        }
        [HttpDelete("{document}")]
        public async Task<IActionResult> Delete(string document)
        {
            await _clientRepository.Delete(document);
            return Ok();
        }
    }
}
