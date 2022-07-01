using Common;
using Server;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonRpc_Server
{
    public class Exe1Obj: IExe1,IJsonRpc
    {
       //public delegate void Exe1Delegate(Exe1Args args);
       
       //public event Exe1Delegate Exe1Event;

       public event EventHandler<Exe1Args> Exe1Event;
        public Exe1Obj()
        {

        }

        public async void PublishInterface()
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            int port = 6000;
            _ = JsonRpcHelper.MarshalRemoteServerObjectAsync(address, port, this);
        }


        public void Exe1Received(Exe1Args args)
        {
            Exe1Event.DynamicInvoke(this, args);     
        }

        public void CheckConnect()
        {
           
        }
    }
}
