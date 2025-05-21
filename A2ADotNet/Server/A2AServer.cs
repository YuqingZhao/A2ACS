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

        private class PartsInMessage
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

        public AgentCard GetAgentCard()
        {
            return DataCopier.Copy<AgentCard>(_agentCard);
        }

        public JSONRPCResponse ProcessJsonRpcRequest(JSONRPCRequest request)
        {
            switch (request.Method)
            {
                case "message/send":
                    var msgText = JsonConvert.SerializeObject(request.Params["message"]);
                    MessageSendConfiguration config = null;
                    if (request.Params.ContainsKey("configuration"))
                    {
                        var configText = JsonConvert.SerializeObject(request.Params["configuration"]);
                        config = JsonConvert.DeserializeObject<MessageSendConfiguration>(configText);
                    }
                    var partsObj = JsonConvert.DeserializeObject<PartsInMessage>(msgText);
                    var msgObj = JsonConvert.DeserializeObject<Message>(msgText);
                    for (var i = 0; i < partsObj.Parts.Count; i++)
                    {
                        switch (partsObj.Parts[i].Kind)
                        {
                            case PartKindEnum.Text:
                                msgObj.Parts[i] = JsonConvert.DeserializeObject<TextPart>(JsonConvert.SerializeObject(msgObj.Parts[i]));
                                break;
                            case PartKindEnum.File:
                                msgObj.Parts[i] = JsonConvert.DeserializeObject<FilePart>(JsonConvert.SerializeObject(msgObj.Parts[i]));
                                break;
                            case PartKindEnum.Data:
                                msgObj.Parts[i] = JsonConvert.DeserializeObject<DataPart>(JsonConvert.SerializeObject(msgObj.Parts[i]));
                                break;
                            default:
                                throw new Exception($"Unknown kind");
                        }
                    }
                    return GetMessageJSONRPCResponse(request.Id, msgObj, _server.OnProcessMessageSend(msgObj));
                default:
                    throw new Exception($"Unknown method {request.Method}");
            }
        }

        private JSONRPCResponse GetMessageJSONRPCResponse(string id, Message request, Message msg)
        {
            var msgObj = JsonConvert.DeserializeObject<Message>(JsonConvert.SerializeObject(msg));
            msgObj.Metadata = request.Metadata;
            msgObj.MessageId = request.MessageId;
            msgObj.Role = request.Role;
            var ret = new JSONRPCResponse()
            {
                Id = id,
                JsonRpc = "2.0",
                Result = msgObj,
            };
            return ret;
        }
    }
}
