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

        protected virtual bool CallRemoteObject(Delegate del, object args)
        {
            if (args == null)
            {
                throw new ArgumentNullException("args");
            }
            object result;
            return CallRemoteObject(args.ToString(), del, out result, args);
        }

        private bool CallRemoteObject(string logString, Delegate del, out object result, params object[] args)
        {
            try
            {
                result = del.DynamicInvoke(args);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

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
