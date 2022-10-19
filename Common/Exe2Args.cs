﻿namespace Common
{
    public class Exe2Args
    {
        private int args1;

        private int args2;

        public int Args1 => args1;

        public int Args2 => args2;

        private string[] parameters;

        public string[] Parameters => parameters;

        public Exe2Args( int args1, int args2,params object[] alarmParameters)
        {
            this.args1 = args1;
            this.args2 = args2;

            if (alarmParameters != null)
            {
                parameters = new string[alarmParameters.Length];
                for (int i = 0; i < alarmParameters.Length; i++)
                {
                    Parameters[i] = ((alarmParameters[i] != null) ? alarmParameters[i].ToString() : "[null]");
                }
            }
            else
            {
                parameters = new string[0];
            }

        }

        public override string ToString()
        {
            string text = $"Parameter:";
            bool flag = true;
            string[] array = parameters;
            foreach (string text2 in array)
            {
                if (flag)
                {
                    flag = false;
                }
                else
                {
                    text += ",";
                }
                text = text + "'" + text2 + "'";
            }
            return text;
        }
    }
}
