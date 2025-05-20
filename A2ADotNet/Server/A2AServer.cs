using System;
using A2ADotNet.Schema;
using A2ADotNet.Utils;

namespace A2ADotNet.Server
{
    public class A2AServer : IServerImpl
    {
        private readonly IServerImpl _server;

        private readonly AgentCard _agentCard;

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
    }
}
