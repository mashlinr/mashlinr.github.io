using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pBoxRocket_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRocketTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrLaunch.Enabled = false;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            tmrLaunch.Enabled = true;
        }

        private void tmrLaunch_Tick(object sender, EventArgs e)
        {
            pBoxRocket.Top -= 5;
            if (pBoxRocket.Top == 0)
            {
                pBoxRocket.Top = 385;
            }
        }
    }
}
