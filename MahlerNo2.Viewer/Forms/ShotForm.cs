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
    public partial class ShotForm : ViewerBaseForm
    {
        private ShotForm()
        {
            InitializeComponent();
        }

        public ShotForm(DateTime date) : this()
        {
            _date = date;
        }

        private readonly DateTime _date;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            Opacity = Settings.Default.Opacity;
            ptbShot.SizeMode = (PictureBoxSizeMode) Settings.Default.SizeMode;
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
                    LoadShot(-1);
                    break;
                case Keys.Control | Keys.Left:
                    LoadShot(-5);
                    break;
                case Keys.Control | Keys.Shift | Keys.Left:
                    LoadShot(-10);
                    break;
                case Keys.Right:
                    LoadShot(1);
                    break;
                case Keys.Control | Keys.Right:
                    LoadShot(5);
                    break;
                case Keys.Control | Keys.Shift | Keys.Right:
                    LoadShot(10);
                    break;
                case Keys.Up:
                    LoadShot(1 * 60);
                    break;
                case Keys.Control | Keys.Up:
                    LoadShot(5 * 60);
                    break;
                case Keys.Control | Keys.Shift | Keys.Up:
                    LoadShot(10 * 60);
                    break;
                case Keys.Down:
                    LoadShot(-1 * 60);
                    break;
                case Keys.Control | Keys.Down:
                    LoadShot(-5 * 60);
                    break;
                case Keys.Control | Keys.Shift | Keys.Down:
                    LoadShot(-10 * 60);
                    break;
                #endregion

                #region opcacity
                case Keys.Add:
                case Keys.Oemplus | Keys.Shift:
                    ChangeOpacity(true);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus | Keys.Shift:
                    ChangeOpacity(false);
                    break;
                    #endregion

                #region size mode
                case Keys.D8:
                    ChangeImageMode(PictureBoxSizeMode.Zoom);
                    break;
                case Keys.D9:
                    ChangeImageMode(PictureBoxSizeMode.StretchImage);
                    break;
                    #endregion
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

        public void LoadShot(int second)
        {
            Cursor = Cursors.WaitCursor;

            uscRemocon.ChangeTime(second);

            string date = _date.ToString(Utility.DateFormat);
            string time = uscRemocon.Time.ToString(Utility.TimeFormat);

            try
            {
                var bytes = ApiClient.Instance.GetShot(date, time);
                ptbShot.Image = Image.FromStream(new MemoryStream(bytes));
                Text = uscRemocon.Time.ToString("HH:mm:ss");
            }
            catch
            {
                Text = "이미지 없음";
            }
            finally
            {
                Cursor = Cursors.Arrow;    
            }
        }

        private void ChangeOpacity(bool increased)
        {
            if (increased && Opacity <= 1)
                Opacity += 0.1;
            else if (!increased && Opacity >= 0.2)
                Opacity -= 0.1;

            Settings.Default.Opacity = Opacity;
        }

        private void ChangeImageMode(PictureBoxSizeMode sizeMode)
        {
            ptbShot.SizeMode = sizeMode;

            Settings.Default.SizeMode = (int) sizeMode;
        }
    }
}