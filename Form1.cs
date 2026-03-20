using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            lblTime.Text = Counter.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Counter = 0;
            lblTime.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Counter = 0;
            lblTime.Text = "0";
        }
    }
}