using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public abstract class TestObjectBase : IObject
    {
        private int id = 1000;

        public int ID => id;

        protected TestObjectBase(int id)
        {
            this.id = id;
        }
    }
}
