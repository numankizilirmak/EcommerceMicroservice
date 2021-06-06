using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EcommerceGitActionTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitTestController : ControllerBase
    {        

        private readonly ILogger<GitTestController> _logger;

        public GitTestController(ILogger<GitTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "api is working v14";
        }
    }
}
