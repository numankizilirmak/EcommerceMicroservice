using Microsoft.AspNetCore.Mvc;


namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController: ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "api is working v1";
        }
    }
}
