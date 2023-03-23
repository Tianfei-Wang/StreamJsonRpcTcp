using Common;
using Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JsonRpc_Server
{
    public class Exe1Obj: IExe1,IJsonRpc
    {
       //public delegate void Exe1Delegate(Exe1Args args);
       
       //public event Exe1Delegate Exe1Event;

       public event EventHandler<Exe1Args> Exe1Event;

        /// <summary>
        /// Store more than hundreds of custom objects that implement the IObject interface.such as Test1Object,Test2Object
        /// </summary>
        private Hashtable testObjectCollections=new Hashtable();
        public Exe1Obj()
        {
            Test1Object test1Object = new Test1Object(1, "Test1ObjectName");
            Test2Object test2Object = new Test2Object(1, "Test2ObjectTag");
            testObjectCollections.Add(typeof(Test1Object), test1Object);
            testObjectCollections.Add (typeof(Test2Object), test2Object);
        }

        public async void PublishInterface()
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            int port = 6000;
            _ = JsonRpcHelper.MarshalRemoteServerObjectAsync<IExe1>(address, port, this);
        }


        public void Exe1Received(Exe1Args args)
        {
            Exe1Event.DynamicInvoke(this, args);     
        }

        public void StatusReport(Exe1Args args)
        {

            Exe1Event.DynamicInvoke(this, args);

        }

        public void CheckConnect()
        {
           
        }

        /// <summary>
        /// Implement the object with a unified interface return value (Task type). 
        /// But,StreamJsonRpc can't seem like NetRemoting during processing
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<IObject> FindNewFromServer(Type type)
        {
            //Use using to consider concurrency restrictions
            if (type.GetInterface(typeof(IObject).Name)==null)
            {
                throw new Exception();
            }
            IObject @object = (IObject)testObjectCollections[type];
            return @object;
        }

        public async Task<Test3Object> GetDeriveObject()
        {
            Test3Object test3Object = new Test3Object(true, new TestObjDerive());
            return test3Object; //the object have “Name” propety 
        }

        TestEventHandler testEventHandler;

        string delId;

        //Register delegates from clients
        public void RegisterDelegate(string delId, TestEventHandler handler)
        {
           testEventHandler = handler;
            this.delId = delId;


            Thread.Sleep(5000);
            TestDelArgs args=new TestDelArgs();
            ToClientCallback(args);
        }

        //Send a callback to the client
        public void ToClientCallback(TestDelArgs args)
        {
            
            if (testEventHandler!=null && args!=null)
            {
                testEventHandler.DynamicInvoke(args);
            }
        }
    }
}
