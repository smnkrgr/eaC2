using Microsoft.AspNetCore.Mvc;

using Server.Services;

namespace Server.Models
{
    [Controller]
    public class HttpListenerController : ControllerBase
    {
        private readonly IAgentService _agents;

        public HttpListenerController(IAgentService agents)
        {
            _agents = agents;
        }

        public IActionResult HandleImplant()
        {
            return Ok("The listener is listening.");
        }
    }
}