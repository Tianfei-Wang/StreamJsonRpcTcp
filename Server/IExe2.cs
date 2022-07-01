using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Server
{
    public interface IExe2:IJsonRpc
    {
        void Exe2Received(Exe2Args args);
    }
}
