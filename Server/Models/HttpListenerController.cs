using Microsoft.AspNetCore.Mvc;

namespace Server.Models
{
    [Controller]
    public class HttpListenerController : ControllerBase
    {
        public IActionResult HandleImplant()
        {
            return Ok("The listener is listening.");
        }
    }
}