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
using StreamJsonRpc;

namespace JsonRpcClient
{
    public partial class Exe2 : Form
    {
        private Exe1Impl exe1Interface;

        private Exe2Obj ex2Obj;
        public Exe2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            exe1Interface = new Exe1Impl();
            exe1Interface.Initialize();

            ex2Obj = new Exe2Obj();
            ex2Obj.PublishInterface();
            ex2Obj.Exe2Event += Show;
        }

        public void Show( Exe2Args args)
        {
            args1.Text = args.Args1.ToString();
            args2.Text = args.Args2.ToString();
            textBoxTest.Text=args.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageToAgv = textBoxSendToExe1.Text;
            var request = new Exe1Args(1, messageToAgv);

            exe1Interface.ToExe1(request);
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
          string name= await exe1Interface.GetTest1ObjectName();
            textBoxTest1Name.Text = name;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
          string tag=await  exe1Interface.GetTest2ObjectTag();
            textBoxTest2Tag.Text = tag;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string name = await exe1Interface.GetObjectDeriveName();
            textBoxDeriveName.Text = name;
        }
    }
}
