using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Whapify.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult getVersion()
        {
            var version = new StringBuilder();
            version.AppendLine("Beta 0.0.0");

            return Ok(version.ToString());
        }
    }
}
