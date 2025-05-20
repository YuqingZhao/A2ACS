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
        private readonly AgentCard _agentCard = new AgentCard
        {
            Name = "WeatherForecast",
            Description = "Weather forecast agent",
            Url = "http://localhost:5270/a2a/api",
            Provider = new ProviderInfo
            {
                Organization = "Example Org",
                Url = "https://example.com"
            },
            Version = "1.0.0",
            DocumentationUrl = "https://example.com/docs",
            Capabilities = new CapabilitiesInfo
            {
                Streaming = false,
                PushNotifications = false
            },
            SecuritySchemes = new Dictionary<string, SecurityScheme>(),
            Security = new List<Dictionary<string, List<string>>>(),
            DefaultInputModes = new List<string> { "application/json", "text/plain" },
            DefaultOutputModes = new List<string> { "application/json", "image/png" },
            Skills = new List<SkillInfo>()
        };

        [HttpGet]
        public void Index()
        {
        }

        [HttpGet("agent.json")]
        public string AgentCard()
        {
            A2AServer svc = new A2AServer(_agentCard, new AppServer());
            return JsonConvert.SerializeObject(svc.GetAgentCard());
        }
    }
}
