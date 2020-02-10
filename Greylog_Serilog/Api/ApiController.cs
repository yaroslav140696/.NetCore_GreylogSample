using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Greylog_Serilog.Api
{
    public sealed class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("api")]
        public async Task<IActionResult> Get()
        {
            _logger.LogError("Hello");
            return Ok();
        }
    }
}