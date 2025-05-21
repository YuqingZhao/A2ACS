using A2ADotNet.Schema;
using A2ADotNet.Server;
using Newtonsoft.Json;

namespace WeatherForecastApp
{
    public class AppServer : IServerImpl
    {


        public static readonly AgentCard AgentCard = new AgentCard
        {
            Name = "WeatherForecast",
            Description = "Weather forecast agent",
            Url = "http://192.168.0.20:5270/a2a/api",
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

        public void OnInit()
        {
            throw new NotImplementedException();
        }

        public JSONRPCResponse OnProcessMessage(Message request)
        {
            return new JSONRPCResponse();
        }
    }
}
