using System;
using System.Windows.Forms;
using MahlerNo2.Core.Forms;
using MahlerNo2.Data;
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

            if (DesignMode || Program.IsRunTime == false)
                return;

            nupShotInterval.Value = Settings.Default.ShotInterval;
            nupEmoticonInterval.Value = Settings.Default.EmotionCheckInterval;
            nupMaxPreviousShot.Value = Settings.Default.MaxPreviousShots;
            nupLatestEmoticonMinute.Value = Settings.Default.LatestEmoticonMinute;
            trbOpacity.Value = Settings.Default.Opacity;
            txtAddress.Text = Settings.Default.Address;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.ShotInterval = Convert.ToInt32(nupShotInterval.Value);
            Settings.Default.EmotionCheckInterval = Convert.ToInt32(nupEmoticonInterval.Value);
            Settings.Default.MaxPreviousShots = Convert.ToInt32(nupMaxPreviousShot.Value);
            Settings.Default.LatestEmoticonMinute = Convert.ToInt32(nupLatestEmoticonMinute.Value);
            Settings.Default.Opacity = trbOpacity.Value;
            Settings.Default.Address = txtAddress.Text;
            Settings.Default.Save();

            DbContextFactory.ChangeIpAddress(Settings.Default.Address);

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