using Server;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Common;
using StreamJsonRpc;
using System.Threading.Tasks;
using System.Drawing;

namespace JsonRpcClient
{
    public class Exe1Impl:JsonRpcClientBase
    {
        public IExe1 Exe1Proxy =>  jsonRpcObject as IExe1;

        public async void Initialize()
        {
            string hostName = "127.0.0.1";
            int port = 6000;

            jsonRpcObject = JsonRpcHelper.GetRemoteInstance<IExe1>(hostName,port);


            /*
            Console.WriteLine("connect to Server...");
            var tcpClient = new TcpClient(hostName, port);
            var jsonRpcStream = tcpClient.GetStream();
            Console.WriteLine("connected Server");

            jsonRpcObject = JsonRpc.Attach<IExe1>(jsonRpcStream);
            */
        }

        public void ToExe1(Exe1Args args)
        {
            Exe1Proxy.Exe1Received(args);
        }

        public async Task<string> GetTest1ObjectName()
        {
            Test1Object test1;
           test1 = (Test1Object)await Exe1Proxy.FindNewFromServer(typeof(Test1Object));
            return test1.Name;
        }

        public async Task<string> GetTest2ObjectTag()
        {
            Test2Object test2;
            test2 = (Test2Object)await Exe1Proxy.FindNewFromServer(typeof(Test2Object));
            return test2.Tag.ToString();
        }


    }
}
