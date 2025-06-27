using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace GS.PrototipoCodex.Controllers.Utils
{
    /// <summary>
    /// Provides utility endpoints.
    /// </summary>
    [ApiController]
    [Route("api/utils")]
    public class UtilsController : ControllerBase
    {
        /// <summary>
        /// Returns application health.
        /// </summary>
        [HttpGet("health")]
        public IActionResult Health() => Ok(new { status = "OK" });

        /// <summary>
        /// Returns current server time.
        /// </summary>
        [HttpGet("time")]
        public IActionResult Time() => Ok(new { serverTime = DateTime.UtcNow });

        /// <summary>
        /// Returns assembly version.
        /// </summary>
        [HttpGet("version")]
        public IActionResult Version()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "unknown";
            return Ok(new { version });
        }
    }
}
