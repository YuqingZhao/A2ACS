using System;
using System.Collections.Generic;
using A2ADotNet.Schema;
using A2ADotNet.Utils;
using Newtonsoft.Json;

namespace A2ADotNet.Server
{
    public class A2AServer
    {
        private readonly IServerImpl _server;

        private readonly AgentCard _agentCard;

        private class InnerMessage
        {
            [JsonProperty("parts")]
            public List<Part> Parts { get; set; }
        }

        public A2AServer(AgentCard agentCard, IServerImpl impl)
        {
            if (agentCard == null)
            {
                throw new ArgumentNullException("AgentCard argument cannot be null.");
            }
            _agentCard = DataCopier.Copy<AgentCard>(agentCard);

            if (impl == null)
            {
                throw new ArgumentNullException("Impl argument cannot be null.");
            }
            _server = impl;
        }

        public void OnInit()
        {
            _server.OnInit();
        }

        public AgentCard GetAgentCard()
        {
            return DataCopier.Copy<AgentCard>(_agentCard);
        }

        public JSONRPCResponse ProcessJsonRpcRequest(JSONRPCRequest request)
        {
            var text = System.Text.Json.JsonSerializer.Serialize(request.Params["message"]);
            var innerObj = JsonConvert.DeserializeObject<InnerMessage>(text);
            var obj = JsonConvert.DeserializeObject<Message>(text);
            for (var i = 0; i < innerObj.Parts.Count; i++)
            {
                switch (innerObj.Parts[i].Kind)
                {
                    case PartKindEnum.Text:
                        obj.Parts[i] = JsonConvert.DeserializeObject<TextPart>(JsonConvert.SerializeObject(obj.Parts[i]));
                        break;
                    case PartKindEnum.File:
                        obj.Parts[i] = JsonConvert.DeserializeObject<FilePart>(JsonConvert.SerializeObject(obj.Parts[i]));
                        break;
                    case PartKindEnum.Data:
                        obj.Parts[i] = JsonConvert.DeserializeObject<DataPart>(JsonConvert.SerializeObject(obj.Parts[i]));
                        break;
                    default:
                        throw new Exception($"Unknown kind");
                }
            }
            return _server.OnProcessMessage(obj);
        }
    }
}
