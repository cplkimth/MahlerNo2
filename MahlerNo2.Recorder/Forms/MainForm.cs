using System;
using System.IO;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Recorder.Components;
using MahlerNo2.Recorder.Properties;

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

            if (DesignMode || Program.OnRunTime == false)
                return;

            Opacity = Settings.Default.Opacity / 100.0;
            Text = PlayFormText;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

#if DEBUG
            TopMost = true;
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
            var directory = Path.Combine(Settings.Default.ShotRoot, DateTime.Today.ToString(Utility.DateFormat));
            Directory.CreateDirectory(directory);
            var fileNameWithoutExtension = DateTime.Now.ToString(Utility.DateTimeFormat);

            var bytes = ScreenShotTaker.Instance.ShotSelectedScreen();

            if (bytes == null)
                return;

            var filePath = Path.Combine(directory, fileNameWithoutExtension + Utility.ImageFileExtension);
            File.WriteAllBytes(filePath, bytes);

            if (txtNote.Text == string.Empty) 
                return;

            filePath = Path.Combine(directory, fileNameWithoutExtension + Utility.NoteFileExtension);
            File.WriteAllText(filePath, txtNote.Text);

            txtNote.Text = string.Empty;
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
    }
}