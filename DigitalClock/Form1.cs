using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            labelHours.Text = DateTime.Now.Hour.ToString("00");
            labelMinutes.Text = DateTime.Now.Minute.ToString("00");
            labelSeconds.Text = DateTime.Now.Second.ToString("00");
            timerSeconds.Start();
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            labelHours.Text = DateTime.Now.Hour.ToString("00");
            labelMinutes.Text = DateTime.Now.Minute.ToString("00");
            labelSeconds.Text = DateTime.Now.Second.ToString("00");
        }
    }
}
