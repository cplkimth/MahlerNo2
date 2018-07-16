using System;
using System.Windows.Forms;
using MahlerNo2.Core.Forms;
using MahlerNo2.Recorder.Properties;

namespace MahlerNo2.Recorder.Forms
{
    public partial class OptionForm : RecorderBaseForm
    {
        private OptionForm()
        {
            InitializeComponent();
        }

        private readonly MainForm _mainForm;

        public OptionForm(MainForm mainForm) : this()
        {
            _mainForm = mainForm;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

            nupShotInterval.Value = Settings.Default.ShotInterval;
            txtShotPath.Text = Settings.Default.ShotRoot;
            trbOpacity.Value = Settings.Default.Opacity;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.ShotInterval = Convert.ToInt32(nupShotInterval.Value);
            Settings.Default.ShotRoot = txtShotPath.Text.Trim();
            Settings.Default.Opacity = trbOpacity.Value;
            Settings.Default.Save();

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trbTranparent_Scroll(object sender, EventArgs e)
        {
            _mainForm.Opacity = trbOpacity.Value / 100.0;
        }
    }
}