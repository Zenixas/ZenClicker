using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace ZenClicker
{


    public partial class Form1 : Form
    {
        private bool activated;
        private bool activated_right;
        private bool clicker;

        public Form1()
        {
            InitializeComponent();
        }

        #region checkbox enable

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) clicker = true;

            else if (!checkBox1.Checked) clicker = false;
        }

        #endregion

        #region form load up

        private void Form1_Load(object sender, EventArgs e)
        {
            // checks if minecraft is opened
            Process[] pid = Process.GetProcessesByName("javaw");

            CheckKeyRight.Start();
            CheckKeyLeft.Start();

            label2.Text = "Min cps: " + LeftMinCPS.Value;
            label3.Text = "Max cps: " + LeftMaxCPS.Value;
            label7.Text = "Min cps: " + RightMinCPS.Value;
            label8.Text = "Max cps: " + RightMaxCPS.Value;
            label5.Text = "Key Down: " + activated;
            label9.Text = "Key Down: " + activated_right;

            if (pid.Length == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Minecraft not found, would you like to continue", "Minecraft not found",
                    buttons);

                if (result == DialogResult.No) Application.Exit();
            }
        }

        #endregion

        #region rightclicking

        private void CheckKeyRight_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyToggled(Key.F2))
            {
                label9.Text = "Key Down: " + (activated_right = true);

                int maxcps = (int) Math.Round(1000 / (RightMaxCPS.Value + RightMinCPS.Value * 0.02));
                int mincps = (int) Math.Round(1000 / (RightMaxCPS.Value + RightMinCPS.Value * 0.04));

                Random rnd = new Random();
                CheckKeyRight.Interval = rnd.Next(mincps, maxcps);

                if (clicker && activated_right) MouseClicks.RightMouseClick();
            }
            else
            {
                label9.Text = "Key Down: " + (activated_right = false);
            }
        }

        #endregion

        #region leftclicking

        private void CheckKeyLeft_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyToggled(Key.F1))
            {
                label5.Text = "Key Down: " + (activated = true);

                int maxcps = (int) Math.Round(1000 / (LeftMaxCPS.Value + LeftMinCPS.Value * 0.02));
                int mincps = (int) Math.Round(1000 / (LeftMaxCPS.Value + LeftMinCPS.Value * 0.04));

                Random rnd = new Random();
                CheckKeyLeft.Interval = rnd.Next(mincps, maxcps);

                if (clicker && activated) MouseClicks.LeftMouseClick();
            }
            else
            {
                label5.Text = "Key Down: " + (activated = false);
            }
        }

        #endregion

        #region self_destruct

        private void SelfDestruct_Click(object sender, EventArgs e)
        {
            checkBox1.Dispose();
            SelfDestruct.Dispose();
            HideInTaskbar.Dispose();
            LeftMinCPS.Dispose();
            LeftMaxCPS.Dispose();
            RightMinCPS.Dispose();
            RightMaxCPS.Dispose();
            label1.Dispose();
            label2.Dispose();
            label3.Dispose();
            label4.Dispose();
            label5.Dispose();
            label6.Dispose();
            label7.Dispose();
            label8.Dispose();
            label9.Dispose();
            CloseButton.Dispose();
            MinimizeButton.Dispose();
            siticoneLabel1.Dispose();
            siticoneImageButton1.Dispose();
            Application.Exit();
        }

        #endregion

        #region hide_taskbar

        private void HideInTaskbar_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !ShowInTaskbar;
        }

        #endregion

        #region right click cps

        private void RightMinCPS_Scroll(object sender, EventArgs e)
        {
            label7.Text = "Min cps: " + RightMinCPS.Value;

            // makes sure max value isnt less than min value
            if (RightMinCPS.Value > RightMaxCPS.Value)
            {
                RightMaxCPS.Value = RightMinCPS.Value;
                label7.Text = "Min cps: " + RightMinCPS.Value;
                label8.Text = "Max cps: " + RightMaxCPS.Value;
            }
        }

        private void RightMaxCPS_Scroll(object sender, EventArgs e)
        {
            label8.Text = "Max cps: " + RightMaxCPS.Value;

            // makes sure min value isnt more than max value
            if (RightMaxCPS.Value < RightMinCPS.Value)
            {
                RightMaxCPS.Value = RightMinCPS.Value;
                label7.Text = "Min cps: " + RightMinCPS.Value;
                label8.Text = "Max cps: " + RightMaxCPS.Value;
            }
        }

        #endregion

        #region left click cps

        private void LeftMinCPS_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Min cps: " + LeftMinCPS.Value;

            // makes sure max value isnt less than min value
            if (LeftMinCPS.Value > LeftMaxCPS.Value)
            {
                LeftMaxCPS.Value = LeftMinCPS.Value;
                label2.Text = "Min cps: " + LeftMinCPS.Value;
                label3.Text = "Max cps: " + LeftMaxCPS.Value;
            }
        }

        private void LeftMaxCPS_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Max cps: " + LeftMaxCPS.Value;

            // makes sure min value isnt more than max value
            if (LeftMaxCPS.Value < LeftMinCPS.Value)
            {
                LeftMaxCPS.Value = LeftMinCPS.Value;
                label2.Text = "Min cps: " + LeftMinCPS.Value;
                label3.Text = "Max cps: " + LeftMaxCPS.Value;
            }
        }

        #endregion

        #region Panel / Movable window / close / minimize

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // https://stackoverflow.com/questions/11379209/how-do-i-make-mousedrag-inside-panel-move-form-window/

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region github button

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Zenixas",
                UseShellExecute = true
            });
        }

        #endregion
    }
}
