using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athlete_Management
{
    public partial class StopwatchForm : Form
    {
        // Add these declarations at the class level
        private System.Diagnostics.Stopwatch stopwatch;
        private Timer timer;

        public StopwatchForm()
        {
            InitializeComponent();
            // Initialize the stopwatch and timer
            stopwatch = new System.Diagnostics.Stopwatch();
            timer = new Timer();
            timer.Interval = 10; // Update every 10 milliseconds
            timer.Tick += Timer_Tick;
        }

        // Rest of your code remains the same
        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            // Initialize the UI
            buttonStop.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time display
            TimeSpan ts = stopwatch.Elapsed;
            labelTime.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Start the stopwatch and timer
            stopwatch.Start();
            timer.Start();
            // Update button states
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Stop the stopwatch and timer
            stopwatch.Stop();
            timer.Stop();
            // Update button states
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset the stopwatch
            stopwatch.Reset();
            // Update the display
            labelTime.Text = "00:00:00.00";
            // Update button states
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }
    }
}