using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    [Serializable]
    public class Exe1Args
    {
        private int agvId;

        private string message;



        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }

        public int AgvId
        {
            get
            {
                return agvId;
            }
            set
            {
                agvId = value;
            }
        }

        public Exe1Args(int agvId, string message)
        {
            this.agvId = agvId;
            this.message = message;
        }

    }
}
