using System;
using System.Runtime.InteropServices;

namespace GUI.Simulation.UI
{
    internal class NativeMethods
    {
        [DllImportAttribute("user32.dll")]
        internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        internal static extern bool ReleaseCapture();
    }
}
