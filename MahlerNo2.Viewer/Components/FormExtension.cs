#region using

using System.Windows.Forms;

#endregion

namespace MahlerNo2.Viewer.Components
{
    public static class FormExtension
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
    }
}