using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class Test1Object :TestObjectBase, IObject
    {

        private string name = "Test1Object";


        public string Name => name;


        public Test1Object(int id,string name) 
            : base(id)
        {
            this.name = name;
        }


    }
}
