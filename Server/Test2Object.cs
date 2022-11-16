using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class Test2Object : TestObjectBase, IObject
    {
       

        private string tag = "Test2Object";

        public string Tag => tag;


        public Test2Object(int id,string tag) 
            : base(id)
        {
            this.tag = tag;
        }
    }
}
