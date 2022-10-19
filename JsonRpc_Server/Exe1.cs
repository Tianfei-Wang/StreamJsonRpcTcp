using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace JsonRpc_Server
{
    public partial class Exe1 : Form
    {
        private Exe1Obj agvInterface = new Exe1Obj();
        
        private Exe2Impl exe2Impl;

        public Exe1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            agvInterface.PublishInterface();
            agvInterface.Exe1Event += ShowText;

        }

        public void ShowText(object sender,Exe1Args args)
        {
            textBoxAgvShow.Text = args.Message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (exe2Impl==null)
            {
                InitExe2Impl();
            }
            
            int args1 = int.Parse(textBoxAgvId.Text);
            int args2 = int.Parse(textBoxTranId.Text);
            string argsTest=textBoxTestArgs.Text;
            Exe2Args exe2Args = new Exe2Args(args1,args2, argsTest);
            exe2Impl.ToExe2Args(exe2Args);
        }

        public void InitExe2Impl()
        {
            exe2Impl = new Exe2Impl();
            exe2Impl.Initialize();
        }
    }
}
