using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class Test3Object
    {
        private bool flag;

        private TestObjBase testObjBase;

        public Test3Object()
        {
        }

        public Test3Object(bool flag, TestObjBase testObjectBase)
        {
            this.Flag = flag;
            this.testObjBase = testObjectBase;
        }

        public bool Flag
        {
            get => flag;
            set => flag = value;
        }
        public TestObjBase TestObjBase
        {
            get => testObjBase;
            set => testObjBase = value;
        }
    }
}
