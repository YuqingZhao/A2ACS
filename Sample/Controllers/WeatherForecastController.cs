using A2ADotNet.Schema;
using A2ADotNet.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WeatherForecastApp;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("a2a")]
    public class WeatherForecastController : Controller
    {
        [HttpGet]
        public void Index()
        {
        }

        [HttpPost("api")]
        public void Post([FromBody]string request) 
        {
        }
    }
}
