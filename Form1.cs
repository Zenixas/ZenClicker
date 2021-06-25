using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Cursor = System.Windows.Forms.Cursor;


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
        private bool activated_right = false;
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
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        #endregion

        #region checkbox enable

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                clicker = true;
            }

            else if (!checkBox1.Checked)
            {
                clicker = false;
            }
        }

        #endregion

        #region form load up

        private void Form1_Load(object sender, EventArgs e)
        {
            // checks if minecraft is opened
            System.Diagnostics.Process[] pid = Process.GetProcessesByName("javaw");

            CheckKeyRight.Start();
            CheckKeyLeft.Start();

            label5.Text = "Key Down: " + activated;
            label9.Text = "Key Down: " + activated_right;

            if (pid.Length == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Minecraft not found, would you like to continue", "Minecraft not found", buttons);

                if (result == System.Windows.Forms.DialogResult.No) { Application.Exit();}
            }

        }

        #endregion

        #region rightclicking

        private void CheckKeyRight_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyToggled(Key.F2))
            {
                label9.Text = "Key Down: " + (activated_right = true);

                int maxcps = (int)Math.Round(1000 / (trackBar4.Value + trackBar3.Value * 0.02));
                int mincps = (int)Math.Round(1000 / (trackBar4.Value + trackBar3.Value * 0.04));

                Random rnd = new Random();
                CheckKeyRight.Interval = rnd.Next(mincps, maxcps);

                while (clicker && activated_right)
                {
                    RightMouseClick();
                }
            }
            else           
                label9.Text = "Key Down: " + (activated_right = false);
        }

        #endregion

        #region leftclicking

        private void CheckKeysLeft_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyToggled(Key.F1))
            {
                label5.Text = "Key Down: " + (activated = true);

                int maxcps = (int)Math.Round(1000 / (trackBar2.Value + trackBar1.Value * 0.02));
                int mincps = (int)Math.Round(1000 / (trackBar2.Value + trackBar1.Value * 0.04));

                Random rnd = new Random();
                CheckKeyLeft.Interval = rnd.Next(mincps, maxcps);

                if (clicker && activated)
                {      
                    LeftMouseClick();
                }
            }
            else       
                label5.Text = "Key Down: " + (activated = false);
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
            button2.Dispose();
            trackBar1.Dispose();
            trackBar2.Dispose();
            trackBar3.Dispose();
            trackBar4.Dispose();
            label1.Dispose();
            label2.Dispose();
            label3.Dispose();
            label4.Dispose();
            label5.Dispose();
            label6.Dispose();
            label7.Dispose();
            label8.Dispose();
            label9.Dispose();
            Application.Exit();
        }

        #endregion

        #region hide_taskbar

        private void button2_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !ShowInTaskbar;
        }

        #endregion

        #region right click cps

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = "Min cps: " + trackBar3.Value;

            // makes sure max value isnt less than min value
            if (trackBar3.Value > trackBar4.Value)
            {
                trackBar4.Value = trackBar3.Value;
                label7.Text = "Min cps: " + trackBar3.Value;
                label8.Text = "Max cps: " + trackBar4.Value;
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label8.Text = "Max cps: " + trackBar4.Value;

            // makes sure min value isnt more than max value
            if (trackBar4.Value < trackBar3.Value)
            {
                trackBar4.Value = trackBar3.Value;
                label7.Text = "Min cps: " + trackBar3.Value;
                label8.Text = "Max cps: " + trackBar4.Value;
            }
        }

        #endregion

        #region left click cps

        
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
    }
}