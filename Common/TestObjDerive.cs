using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    //We will have many classes derived from TestObjectBase, and this is one of them
    public class TestObjDerive:TestObjBase
    {
        private bool flag=true;

        private string name="TestObjectDerive";

        public bool Flag
        {
            get => flag;
            set => flag = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
