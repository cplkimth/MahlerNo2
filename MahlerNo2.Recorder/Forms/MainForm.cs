using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using MahlerNo2.Core.Components;
using MahlerNo2.Recorder.Components;
using MahlerNo2.Recorder.Properties;

namespace MahlerNo2.Recorder.Forms
{
    public partial class MainForm : Form
    {
        private const string DateFormat = "yyMMdd";
        private const string TimeFormat = "HHmmss";

        private const string PlayFormText = @"▶";
        private const string PauseFormText = @"⏸";

        public MainForm()
        {
            InitializeComponent();

            KeyboardHook.Hook(Core.Components.ModifierKeys.Control | Core.Components.ModifierKeys.Alt, Keys.F11,
                (sender, args) => tsbNote.PerformClick());
            KeyboardHook.Hook(Core.Components.ModifierKeys.Control | Core.Components.ModifierKeys.Alt, Keys.F12,
                (sender, args) => tsbPlay.PerformClick());
        }

        private Note _node;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

            Text = PlayFormText;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

#if DEBUG
#else
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
            var directory = Path.Combine(Settings.Default.ShotRoot, DateTime.Today.ToString(DateFormat));
            Directory.CreateDirectory(directory);
            var fileNameWithoutExtension = DateTime.Now.ToString(DateFormat + "_" + TimeFormat);

            var bytes = ScreenShotTaker.Instance.ShotSelectedScreen();

            if (bytes != null)
            {
                var filePath = Path.Combine(directory, fileNameWithoutExtension + ".png");
                File.WriteAllBytes(filePath, bytes);
            }

            if (_node != null)
            {
                var json = JsonConvert.SerializeObject(_node);
                var filePath = Path.Combine(directory, fileNameWithoutExtension + ".json");
                File.WriteAllText(filePath, json);

                _node = null;
                lblNote.Text = string.Empty;
            }
        }

        private void tsbOption_Click(object sender, EventArgs e)
        {
            StopTimer();

            var form = new OptionForm(this);
            if (form.ShowDialog() == DialogResult.OK) tmrShot.Interval = Settings.Default.ShotInterval * 1000;

            StartTimer();
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            if (tmrShot.Enabled)
                StopTimer();
            else
                StartTimer();
        }

        private void StopTimer()
        {
//            WindowState = FormWindowState.Normal;
            tmrShot.Enabled = false;
            Text = PlayFormText;
            tsbPlay.Image = Resources.Play;
        }

        private void StartTimer()
        {
//            WindowState = FormWindowState.Minimized;
            tmrShot.Enabled = true;
            Text = PauseFormText;
            tsbPlay.Image = Resources.Pause;
        }

        private void tsbNote_Click(object sender, EventArgs e)
        {
            StopTimer();

            grbNote.Enabled = true;

            if (Clipboard.GetData(DataFormats.Text) is string clipboardText)
                txtNote.Text = clipboardText;

            txtNote.Focus();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            _node = new Note(rdbText.Checked ? NoteType.Text : NoteType.Url, txtNote.Text);
            grbNote.Enabled = false;

            StartTimer();
        }

        private void btnCancelNote_Click(object sender, EventArgs e)
        {
            txtNote.Text = string.Empty;
            grbNote.Enabled = false;

            StartTimer();
        }
    }
}