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
        private delegate void StatusReportDelegate(Exe1Args args);

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

        public void StatusReportToExe2(int agvId, string message)
        {
            CallRemoteObject(new StatusReportDelegate(ToExe1StatusReport),new Exe1Args(agvId,message));
        }

        public void ToExe1StatusReport(Exe1Args args)
        {
            Exe1Proxy.StatusReport(args);
        }

        public void ToExe1RegisterDelegate(string delId, TestEventHandler handler)
        {
            Exe1Proxy.RegisterDelegate(delId,handler);
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

        public async Task<string> GetObjectDeriveName()
        {
            Test3Object test3Object;
            test3Object = (Test3Object)await Exe1Proxy.GetDeriveObject();
            return ((TestObjDerive)test3Object.TestObjBase).Name; //Data loss due to Json's handling of base classes, Unable to convert

        }


    }
}
