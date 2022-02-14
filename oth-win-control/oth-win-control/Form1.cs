using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oth_win_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // P/Invoke declarations.

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern int GetClientRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOZORDER = 0x0004;

        private void button1_Click(object sender, EventArgs e)
        {
            // Find (the first-in-Z-order) Notepad window.
            IntPtr hWnd = FindWindow(tb_winname.Text, null);
            // If found, position it.
            if (hWnd != IntPtr.Zero)
            {
                // Move the window to (0,0) without changing its size or position
                // in the Z order.
                RECT rc = new RECT();
                GetWindowRect(hWnd, out rc);
                tb_left.Text = $"top: {rc.left}";
                tb_top.Text = $"top: {rc.top}";
                tb_right.Text = $"top: {rc.right}";
                tb_bottom.Text = $"top: {rc.bottom}";
                SetWindowPos(hWnd, IntPtr.Zero, 20, Screen.PrimaryScreen.WorkingArea.Height - (rc.bottom - rc.top) - 20, 0, 0, SWP_NOSIZE | SWP_NOZORDER);
            }
        }
    }
}
