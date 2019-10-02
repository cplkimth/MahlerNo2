using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Data;
using MahlerNo2.Recorder.Components;
using MahlerNo2.Recorder.Properties;
using Tulpep.NotificationWindow;

namespace MahlerNo2.Recorder.Forms
{
    public partial class MainForm : RecorderBaseForm
    {
        private const string PlayFormText = @"▶";
        private const string PauseFormText = @"⏸";

        public MainForm()
        {
            InitializeComponent();

            KeyboardHook.Hook(Core.Components.ModifierKeys.Control, Keys.F12,
                (sender, args) => tsbPlay.PerformClick());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.Alt | Keys.F11:
                    if (Clipboard.GetData(DataFormats.Text) is string clipboardText)
                        txtNote.Text = clipboardText;
                    tsbPlay.PerformClick();
                    break;

                case Keys.Control | Keys.Alt | Keys.F12:
                    tsbPlay.PerformClick();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            Opacity = Settings.Default.Opacity / 100.0;
            Text = PlayFormText;

            DbContextFactory.ChangeIpAddress(Settings.Default.Address);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

#if DEBUG

#else
TopMost = true;
if (Screen.AllScreens.Length > 1)
            {
                var form = new ScreenSelectionForm();
                form.ShowDialog();

                if (ScreenShotTaker.Instance.Screen == null)
                {
                    MessageBox.Show("스크린이 선택되지 않았습니다.");
                    Close();
                }
            }
#endif
        }

        private void tmrShot_Tick(object sender, EventArgs e)
        {
            var bytes = ScreenShotTaker.Instance.Shot(Settings.Default.MaxPreviousShots);

            if (bytes == null)
                return;

            try
            {
                tsiCamera.Enabled = true;

                DataRepository.Shot.Save(bytes, txtNote.Text);
            }
            catch (Exception ex)
            {
                Text = $"{DateTime.Now.ToShortTimeString()} : {ex.Message}";
            }
            finally
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += OnTime;
                timer.Start();
            }

            txtNote.Text = string.Empty;
        }

        private void OnTime(object sender, EventArgs e)
        {
            tsiCamera.Enabled = false;
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
            timer.Stop();
            timer.Dispose();
        }

        private void tsbOption_Click(object sender, EventArgs e)
        {
            TopMost = false;

            var form = new OptionForm(this);
            if (form.ShowDialog() == DialogResult.OK)
                tmrShot.Interval = Settings.Default.ShotInterval * 1000;

            TopMost = true;
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            if (tmrShot.Enabled)
                StopTakingShot();
            else
                StartTakingShot();
        }

        private void Popup_Click(object sender, EventArgs e)
        {
            tsbPlay.PerformClick();
            WindowState = FormWindowState.Minimized;
        }

        private void StopTakingShot()
        {
            //            WindowState = FormWindowState.Normal;
            tmrShot.Enabled = false;
            Text = PlayFormText;
            tsbPlay.Image = Resources.Play;
        }

        private void StartTakingShot()
        {
            //            WindowState = FormWindowState.Minimized;
            tmrShot.Enabled = true;
            Text = PauseFormText;
            tsbPlay.Image = Resources.Pause;
        }

        private void txtNote_Enter(object sender, EventArgs e)
        {
            StopTakingShot();
        }

        private void txtNote_Leave(object sender, EventArgs e)
        {
            StartTakingShot();
        }

        private void tmrBreakTime_Tick(object sender, EventArgs e)
        {
            //var breakTime = BreakTimeManager.Instance.GetBreakTimeText();

            //if (breakTime == null)
            //    return;

            //await TtsHelper.SpeakAsync(breakTime);
        }

        private void TmrNotification_Tick(object sender, EventArgs e)
        {
            if (tmrShot.Enabled)
                return;

            PopupNotifier popup = new PopupNotifier();
            popup.ImageSize = new System.Drawing.Size(200,131);
            popup.Image = Resources.Popup;
            popup.Click += Popup_Click;
            popup.ContentText = "Play!";
            popup.ContentFont = new System.Drawing.Font(Font.FontFamily, 30);
            popup.Popup();
        }
    }
}