using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StreamJsonRpc;

namespace Common
{
    public abstract class JsonRpcClientBase:IJsonRpc
    {
        protected  IJsonRpc jsonRpcObject;

        public async void Initialize(string hostname,int port)
        {

            Console.WriteLine("connect to Server...");
            var tcpClient = new TcpClient(hostname, port);
            var jsonRpcStream = tcpClient.GetStream();
            Console.WriteLine("connected");

            jsonRpcObject = JsonRpc.Attach<IJsonRpc>(jsonRpcStream);

        }

        public void CheckConnect()
        {

        }
    }
}
