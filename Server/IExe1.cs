using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IExe1:IJsonRpc
    {
        void Exe1Received(Exe1Args args);

        //StreamJsonRpc only supports the return of Task types? And .NetRemoting is different
        Task<IObject> FindNewFromServer(Type type);

    }
}
