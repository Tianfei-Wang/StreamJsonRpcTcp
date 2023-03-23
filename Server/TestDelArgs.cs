using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    [Serializable]
    public class TestDelArgs
    {
        private DateTime createAt = DateTime.Now;

        public TestDelArgs()
        {
        }

        public DateTime CreateAt
        {
            get => createAt;
            set => createAt = value;
        }


    }
}
