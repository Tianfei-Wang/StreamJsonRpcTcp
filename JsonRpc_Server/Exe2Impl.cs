using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Common;
using Server;
using StreamJsonRpc;

namespace JsonRpc_Server
{
    public class Exe2Impl:JsonRpcClientBase
    {
        public IExe2 Exe2Proxy => (IExe2)jsonRpcObject;

        public async void Initialize()
        {
            string hostName = "127.0.0.1";
            int port = 6100;
            Console.WriteLine("connect to server...");
            var tcpClient = new TcpClient(hostName, port);
            var jsonRpcStream = tcpClient.GetStream();
            Console.WriteLine("connected");
            jsonRpcObject = JsonRpc.Attach<IExe2>(jsonRpcStream);
        }

        public void ToExe2Args(Exe2Args args)
        {
            Exe2Proxy.Exe2Received(args);
        }

    }
}
