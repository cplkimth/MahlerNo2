#region
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Viewer.Components;
using MahlerNo2.Viewer.Properties;
#endregion

namespace MahlerNo2.Viewer.Forms
{
    public partial class ViewerFormEx : Form
    {
        private ViewerFormEx()
        {
            InitializeComponent();
        }

        public ViewerFormEx(DateTime date) : this()
        {
            _date = date;
        }

        private readonly DateTime _date;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Save();

            base.OnClosing(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    ToggleRemoveVisible();
                    break;

                #region move

                case Keys.Left:
                    uscRemocon.ChangeTime(-1);
                    break;
                case Keys.Control | Keys.Left:
                    uscRemocon.ChangeTime(-5);
                    break;
                case Keys.Control | Keys.Shift | Keys.Left:
                    uscRemocon.ChangeTime(-10);
                    break;
                case Keys.Right:
                    uscRemocon.ChangeTime(1);
                    break;
                case Keys.Control | Keys.Right:
                    uscRemocon.ChangeTime(5);
                    break;
                case Keys.Control | Keys.Shift | Keys.Right:
                    uscRemocon.ChangeTime(10);
                    break;
                case Keys.Up:
                    uscRemocon.ChangeTime(1*60);
                    break;
                case Keys.Control | Keys.Up:
                    uscRemocon.ChangeTime(5*60);
                    break;
                case Keys.Control | Keys.Shift | Keys.Up:
                    uscRemocon.ChangeTime(10*60);
                    break;
                case Keys.Down:
                    uscRemocon.ChangeTime(-1*60);
                    break;
                case Keys.Control | Keys.Down:
                    uscRemocon.ChangeTime(-5*60);
                    break;
                case Keys.Control | Keys.Shift | Keys.Down:
                    uscRemocon.ChangeTime(-10*60);
                    break;

                #endregion

//                case Keys.Escape:
//                    btnExit.PerformClick();
//                    Close();
//                    break;
//                case Keys.Control | Keys.B:
//                    btnBrowse.PerformClick();
//                    break;
//                case Keys.Control | Keys.R:
//                    btnRefresh.PerformClick();
//                    break;
//                case Keys.Control | Keys.T:
//                    btnRatio.PerformClick();
//                    break;
//                case Keys.Control | Keys.N:
//                    btnNote.PerformClick();
//                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ToggleRemoveVisible()
        {
            if (uscRemocon.Width == 0)
                uscRemocon.Width = 128;
            else
                uscRemocon.Width = 0;
        }

        private void ShowShot(string date, string time)
        {
            Cursor = Cursors.WaitCursor;

            var bytes = ApiClient.Instance.GetShot(date, time);
            ptbShot.Image = Image.FromStream(new MemoryStream(bytes));

            Cursor = Cursors.Arrow;
        }

        private void uscRemocon_TimeChanged(object sender, Controls.RemoconControl.TimeChangedEventArgs e)
        {
            Text = _date.ToString(Utility.DateFormat) + "_" + uscRemocon.Time.ToString(Utility.TimeFormat);

            ShowShot(_date.ToString(Utility.DateFormat), uscRemocon.Time.ToString(Utility.TimeFormat));
        }

        private void uscRemocon_OpacityChanging(object sender, Controls.RemoconControl.OpacityChangingEventArgs e)
        {
            if (e.Increasing && Opacity <= 1)
                Opacity += 0.1;
            else if (!e.Increasing && Opacity >= 0.1)
                Opacity -= 0.1;
        }
    }
}