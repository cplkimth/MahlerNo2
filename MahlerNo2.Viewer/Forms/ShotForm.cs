#region
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Data;
using MahlerNo2.Data.Components;
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
            ptbShot.SizeMode = (PictureBoxSizeMode)Settings.Default.SizeMode;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var dateDirectory = LocalShotManager.Instance.GetDirectoryForDate(_date.ToDateString());

            try
            {
                Directory.Delete(dateDirectory, true);
            }
            catch
            {
                MessageBox.Show($"아래 임시 디렉토리를 삭제하지 못하였습니다. 수동으로 지워주세요.\r\n\r\n{dateDirectory}");
            }

            base.OnClosing(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Tab:
                    ToggleRemoconVisible();
                    break;
                case Keys.Enter:
                    ToggleWindowSize();
                    break;
                case Keys.Escape:
                    Close();
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

        private void ToggleWindowSize()
        {
            if (FormBorderStyle == FormBorderStyle.None)
                FormBorderStyle = FormBorderStyle.Sizable;
            else
                FormBorderStyle = FormBorderStyle.None;
        }

        private void ToggleRemoconVisible()
        {
            if (uscRemocon.Width == 0)
                uscRemocon.Width = 128;
            else
                uscRemocon.Width = 0;
        }

        private void LoadShot(int second)
        {
            Cursor = Cursors.WaitCursor;

            uscRemocon.ChangeTime(second);

            string date = _date.ToDateString();
            string time = uscRemocon.Time.ToTimeString();

            try
            {
                byte[] bytes = null;
                if (Program.OfflineMode)
                    bytes = OfflineShotManager.Instance.Load(date, time);
                else
                    bytes = DataRepository.Shot.Load(date, time);

                ptbShot.Image = Image.FromStream(new MemoryStream(bytes));
                Text = uscRemocon.Time.Date.ToLongDateString();
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

            Settings.Default.SizeMode = (int)sizeMode;
        }

        private void uscRemocon_BackupClicked(object sender, Controls.RemoconControl.BackupClickedEventArgs e)
        {
            BackupForm form = new BackupForm(_date);
            form.ShowDialog();
        }
    }
}