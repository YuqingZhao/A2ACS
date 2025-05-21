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
        public JSONRPCResponse Post([FromBody] JSONRPCRequest request)
        {
            A2AServer svc = new A2AServer(AppServer.AgentCard, new AppServer());
            return svc.ProcessJsonRpcRequest(request);
        }
    }
}
