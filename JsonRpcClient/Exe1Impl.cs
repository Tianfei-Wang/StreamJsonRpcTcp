using Server;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Common;
using StreamJsonRpc;

namespace JsonRpcClient
{
    public class Exe1Impl:JsonRpcClientBase
    {
        public IExe1 Exe1Proxy =>  jsonRpcObject as IExe1;

        public async void Initialize()
        {
            string hostName = "127.0.0.1";
            int port = 6000;
            
            Console.WriteLine("connect to Server...");
            var tcpClient = new TcpClient(hostName, port);
            var jsonRpcStream = tcpClient.GetStream();
            Console.WriteLine("connected Server");

            jsonRpcObject = JsonRpc.Attach<IExe1>(jsonRpcStream);

        }

        public void ToExe1(Exe1Args args)
        {
            Exe1Proxy.Exe1Received(args);
        }


    }
}
