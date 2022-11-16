using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using StreamJsonRpc;

namespace Common
{
    public static class JsonRpcHelper
    {
        public static async Task MarshalRemoteServerObjectAsync<T>(IPAddress address, int port, T agvInterface)
            where T : IJsonRpc
        {
            int clientId = 1;
            TcpListener tcpListener = new TcpListener(address, port);
            tcpListener.Start();
            while (true)
            {
                Console.WriteLine("waiting Cliuent connect...");
                TcpClient client = await tcpListener.AcceptTcpClientAsync();
                NetworkStream stream = client.GetStream();
                Console.WriteLine($"Connected Client #{clientId} ");
                _ = TcpResponseAsync(stream, clientId, agvInterface);
                clientId++;
            }
        }

        static async Task TcpResponseAsync<T>(NetworkStream stream, int clientId, T agvInterface)
            where T : IJsonRpc
        {
            var jsonRpc = new JsonRpc(stream);
            jsonRpc.AddLocalRpcTarget<T>(agvInterface, null);
            jsonRpc.StartListening();
            await jsonRpc.Completion;
            Console.WriteLine($"Client #{clientId} Disconnect");
            jsonRpc.Dispose();
            await stream.DisposeAsync();
        }

        public static IJsonRpc GetRemoteInstance<T>(string hostName, int port)
            where T : class
        {
            Console.WriteLine("connect to Server...");
            var tcpClient = new TcpClient(hostName, port);
            var jsonRpcStream = tcpClient.GetStream();
            Console.WriteLine("connected Server");

            T jsonRpcObject = JsonRpc.Attach<T>(jsonRpcStream);
            return (IJsonRpc)jsonRpcObject;
        }
    }
}
