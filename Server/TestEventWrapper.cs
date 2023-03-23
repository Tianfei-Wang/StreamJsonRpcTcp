using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class TestEventWrapper
    {
        public event TestEventHandler Event;

        public void OnEvent(string del, TestDelArgs args)
        {
            if (this.Event != null)
            {
                this.Event(del, args);
            }
        }
    }
}
