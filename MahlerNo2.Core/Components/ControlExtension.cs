#region
using System;
using System.Windows.Forms;
#endregion

namespace MahlerNo2.Core.Components
{
    public static class ControlExtension
    {
        public static void RunWithWaitCursor(this Control control, Action action)
        {
            control.Cursor = Cursors.WaitCursor;
            action();
            control.Cursor = Cursors.Arrow;
        }
    }
}