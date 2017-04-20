using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LivestreamerLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string  input   = Microsoft.VisualBasic.Interaction.InputBox("Enter channel name", "Livestreamer twitch launcher", "cheedon0904", -1, -1);

            if(!input.Equals("")) {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "d:/Program Files (x86)/Livestreamer/livestreamer.exe";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.StartInfo.Arguments = string.Format("--http-header Client-ID=jzkbprff40iqj646a697cyrvl0zt2m6 twitch.tv/{0} best", input);
                cmd.Start();
            }
            Application.Exit();
        }
    }
}
