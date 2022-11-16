using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Common;
using Server;

namespace JsonRpcClient
{
    public class Exe2Obj : IExe2
    {
        public delegate void Exe2Delegate(Exe2Args args);

        public event Exe2Delegate Exe2Event;

        //public event EventHandler<Exe2Args> Exe2Event;
        public void CheckConnect()
        {
            
        }

        public async void PublishInterface()
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            int port = 6100;
            _ = JsonRpcHelper.MarshalRemoteServerObjectAsync<IExe2>(address, port, this);
        }

        /// <summary>
        /// Implement StreamJsonRpc's handling of delegates event
        /// </summary>
        /// <param name="args"></param>
        public void Exe2Received(Exe2Args args)
        {
            Exe2Event.DynamicInvoke(args);
        }
    }
}
