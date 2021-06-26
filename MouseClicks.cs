﻿using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZenClicker
{
    public class MouseClicks
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        #region mouse_actions

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        #endregion

        #region mouse_clicks

        public static void RightMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint) Cursor.Position.X;
            uint Y = (uint) Cursor.Position.Y;

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        public static void LeftMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint) Cursor.Position.X;
            uint Y = (uint) Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        #endregion
    }
}