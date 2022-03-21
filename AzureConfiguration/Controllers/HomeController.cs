using Microsoft.AspNetCore.Mvc;

namespace AzureConfiguration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public string Get()
        {
            string name = _config.GetValue<string>("azureconfig:name");
            return name;
        }
    }
}
