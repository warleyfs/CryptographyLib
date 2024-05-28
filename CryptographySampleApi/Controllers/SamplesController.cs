using CryptographyLib.Models;
using CryptographyLib.Models.MSCryptographyModel;
using CryptographyLib.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CryptographySampleApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SamplesController : ControllerBase
    {
        private readonly IAsymmetricEncryptionService _asymmetricEncryptionService;
        private readonly ISymmetricEncryptionService _symmetricEncryptionService;

        public SamplesController(IAsymmetricEncryptionService asymmetricEncryptionService, ISymmetricEncryptionService symmetricEncryptionService)
        {
            _asymmetricEncryptionService = asymmetricEncryptionService;
            _symmetricEncryptionService = symmetricEncryptionService;
        }

        [HttpGet("DecryptAsymmetric")]
        [ProducesResponseType(typeof(AsymmetricDecryptionResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromBody] AsymmetricDecryptionRequest request)
        {
            var result = await _asymmetricEncryptionService.DecryptAsync(request);
            return Ok(result);
        }

        [HttpPost("EncryptAsymmetric")]
        [ProducesResponseType(typeof(AsymmetricEncryptionResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Post([FromBody]AsymmetricEncryptionRequest request)
        {
            var result = await _asymmetricEncryptionService.EncryptAsync(request);
            return Ok(result);
        }

        [HttpGet("DecryptSymmetric")]
        [ProducesResponseType(typeof(SymmetricDecryptionResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromBody]SymmetricDecryptionRequest request)
        {
            var result = await _symmetricEncryptionService.DecryptAsync(request);
            return Ok(result);
        }

        [HttpPost("EncryptSymmetric")]
        [ProducesResponseType(typeof(SymmetricEncryptionResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Post([FromBody]SymmetricEncryptionRequest request)
        {
            var result = await _symmetricEncryptionService.EncryptAsync(request);
            return Ok(result);
        }
    }
}
