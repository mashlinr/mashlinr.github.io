using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket_Launcher
{
    public partial class Form1 : Form
    {
        private int countdownSeconds = 5;

        public Form1()
        {
            InitializeComponent();
            tmrLaunch.Interval = 1000;
        }

        private void pBoxRocket_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ExecuteLiftOff();
                tmrLaunch.Enabled = true;
            }
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
            pBoxRocket.Top = 360;
            btnLaunch.Text = "Launch";
            tmrLaunch.Interval = 1000;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            countdownSeconds = 5;
            btnLaunch.Text = "Launching in: " + countdownSeconds;
            tmrLaunch.Enabled = true;
        }

        private void tmrLaunch_Tick(object sender, EventArgs e)
        {
            if (countdownSeconds > 0)
            {
                countdownSeconds--;
                if (countdownSeconds > 0)
                {
                    btnLaunch.Text = "Launching in: " + countdownSeconds;
                }
                else
                {
                    btnLaunch.Text = "Launch";
                    ExecuteLiftOff();
                    tmrLaunch.Interval = 50;
                }
                return;
            }

            pBoxRocket.Top -= 5;
            if (pBoxRocket.Top <= 0)
            {
                pBoxRocket.Top = 360;
            }
        }

        private void ExecuteLiftOff()
        {
            lblRocketTitle.Text = "Lift off!";
            MessageBox.Show("lift off");
        }
    }
}
