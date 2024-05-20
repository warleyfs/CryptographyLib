using CryptographyLib.Models;
using CryptographyLib.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CryptographySampleApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SamplesController : ControllerBase
    {
        private readonly IEncryptionService _encryptionService;

        public SamplesController(IEncryptionService encryptionService)
        {
            _encryptionService = encryptionService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(DecryptedResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var result = await _encryptionService.DecryptAsync("Teste");
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(EncryptedResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> Post()
        {
            var result = await _encryptionService.EncryptAsync("Teste");
            return Ok(result);
        }
    }
}
