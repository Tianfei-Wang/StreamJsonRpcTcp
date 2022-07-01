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
        public static async Task MarshalRemoteServerObjectAsync(IPAddress address, int port, IJsonRpc agvInterface)
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

        static async Task TcpResponseAsync(NetworkStream stream, int clientId, IJsonRpc agvInterface)
        {
            var jsonRpc = JsonRpc.Attach(stream, agvInterface);
            await jsonRpc.Completion;
            Console.WriteLine($"Client #{clientId} Disconnect");
            jsonRpc.Dispose();
            await stream.DisposeAsync();
        }
    }
}
