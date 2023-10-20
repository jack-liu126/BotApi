using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> HelloWorld()
        {
            ContentResult cr = new ContentResult();
            return cr;
        }
    }
}
