using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading;

namespace ZenClicker
{
    public partial class Form1 : Form
    {
        #region mouse_actions

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        #endregion

        private bool clicker = false;
        private bool activated = false;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        #region mouse_clicks

        public void RightMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        public void LeftMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint) Cursor.Position.X;
            uint Y = (uint) Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                clicker = true;
                timer1.Start();
            }
                                
            else if (!checkBox1.Checked)
            {
                clicker = false;
                timer1.Stop();
            }
                
            label1.Text = "status: " + (clicker ? "enabled" : "disabled");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // checks if minecraft is opened
            System.Diagnostics.Process[] pid = System.Diagnostics.Process.GetProcessesByName("javaw");

            KeyPreview = true;
            
            if (pid.Length == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Minecraft not found, would you like to continue", "Minecraft not found", buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    Application.Exit();
                }
            }

        }

        #region cps

        // min cps
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Min cps: " + trackBar1.Value;

            // makes sure max value isnt less than min value
            if (trackBar1.Value > trackBar2.Value)
            {
                trackBar2.Value = trackBar1.Value;
                label2.Text = "Min cps: " + trackBar1.Value;
                label3.Text = "Max cps: " + trackBar2.Value;
            }
        }

        //max cps
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Max cps: " + trackBar2.Value;

            // makes sure min value isnt more than max value
            if (trackBar2.Value < trackBar1.Value)
            {
                trackBar2.Value = trackBar1.Value;
                label2.Text = "Min cps: " + trackBar1.Value;
                label3.Text = "Max cps: " + trackBar2.Value;
            }
        }

        #endregion

        #region self_destruct

        private void button1_Click(object sender, EventArgs e)
        {
            self_destruct();
        }

        private void self_destruct()
        {
            checkBox1.Dispose();
            button1.Dispose();
            label1.Dispose();
            label2.Dispose();
            label3.Dispose();
            trackBar1.Dispose();
            trackBar2.Dispose();
            button2.Dispose();
            label4.Dispose();
            Application.Exit();
        }

        #endregion

        #region hide_taskbar

        private void button2_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !ShowInTaskbar;
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            while (clicker && activated)
            {
                int delay = 1000 / rnd.Next(trackBar1.Value, trackBar2.Value);
                LeftMouseClick();
                Thread.Sleep(delay);

            }
        }
    }
}