using A2ADotNet.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace A2ADotNet.Server
{
    public interface IServerImpl
    {
        Message OnProcessMessageSend(Message request);
    }
}
