using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZenClicker
{
    public partial class Form1 : Form
    {
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private bool clicker;


        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint) Cursor.Position.X;
            uint Y = (uint) Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                clicker = true;
            else if (!checkBox1.Checked) clicker = false;

            
            label1.Text = "status: " + (clicker ? "enabled" : "disabled");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


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
            Application.Exit();
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


    }
}