#region
using System;
using System.ComponentModel;
using System.Threading;
using MahlerNo2.Core.Controls;
using MahlerNo2.Data;
using MahlerNo2.Recorder.Components;
#endregion

namespace MahlerNo2.Recorder.Controls
{
    public partial class SpeechListControl : BaseUserControl
    {
        public SpeechListControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            bgwSpeech.RunWorkerAsync();
        }

        private void bgwSpeech_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);

                var speechText = DataRepository.Speech.PickFirstText();

                if (speechText == null)
                    continue;    

                bgwSpeech.ReportProgress(0, speechText);
            }
        }

        private void bgwSpeech_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var speechText = (string) e.UserState;

            if (chbToSpeacker.Checked)
                TtsHelper.Speak(speechText);

            dgvSpeech.Rows.Add(DateTime.Now.ToShortTimeString(), speechText);
            dgvSpeech.FirstDisplayedScrollingRowIndex = dgvSpeech.RowCount - 1;
        }
    }
}