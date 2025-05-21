using A2ADotNet.Schema;
using A2ADotNet.Server;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WeatherForecastApp;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route(".well-known")]
    public class AgentCardController : Controller
    {
        [HttpGet]
        public void Index()
        {
        }

        [HttpGet("agent.json")]
        public string AgentCard()
        {
            A2AServer svc = new A2AServer(AppServer.AgentCard, new AppServer());
            return JsonConvert.SerializeObject(svc.GetAgentCard());
        }
    }
}
