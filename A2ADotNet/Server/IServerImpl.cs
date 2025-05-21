using A2ADotNet.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace A2ADotNet.Server
{
    public interface IServerImpl
    {
        void OnInit();

        JSONRPCResponse OnProcessMessage(Message request);
    }
}
