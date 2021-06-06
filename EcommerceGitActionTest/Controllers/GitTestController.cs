using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return "api is working v13";
        }
    }
}
