#region using
using System;
using System.Windows.Forms;

#endregion

namespace MahlerNo2.Viewer.Components
{
    public static class WinformHelper
    {
        public static void EnterFullScreenMode(this Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public static void LeaveFullScreenMode(this Form targetForm)
        {
            targetForm.FormBorderStyle = FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }

        public static void Run(this Form form, Action action)
        {
            try
            {
                form.Cursor = Cursors.WaitCursor;

                action();
            }
            finally
            {
                form.Cursor = Cursors.Arrow;                
            }
        }
    }
}