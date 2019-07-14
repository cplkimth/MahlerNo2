#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Data;
using MahlerNo2.Data.Components;
using MahlerNo2.Viewer.Components;
using MahlerNo2.Viewer.Properties;

#endregion

namespace MahlerNo2.Viewer.Forms
{
    public partial class BackupForm : ViewerBaseForm
    {
        private BackupForm()
        {
            InitializeComponent();
        }

        public BackupForm(DateTime date) : this()
        {
            _date = date;
        }

        private readonly DateTime _date;

        private string _dateText;

        private List<DateTime> _times;

        public string DateText => _dateText ?? (_dateText = _date.ToDateString());

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            _times = DataRepository.Shot.LoadForDate(DateText);

            txtFolder.Text = OfflineShotManager.Instance.GetDirectoryForDate(DateText);
            fbdDownload.SelectedPath = txtFolder.Text;
            prbProgress.Maximum = _times.Count;
            lblCount.Text = $"{_times.Count:N0} 건을 다운로드합니다.";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;

            bgwDownloader.RunWorkerAsync(_times);
        }

        private void bgwDownloader_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<DateTime> times = (List<DateTime>)e.Argument;

            int count = 0;

            foreach (var time in times)
            {
                count++;

                string timeText = time.ToTimeString();

                var image = DataRepository.Shot.SelectFirst(x => x.At == time, x => x.Data);

                OfflineShotManager.Instance.Save(DateText, timeText, image);

                bgwDownloader.ReportProgress(count, timeText);
            }
        }

        private void bgwDownloader_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            prbProgress.Value = e.ProgressPercentage;

            string timeText = (string) e.UserState;
            timeText = timeText.Insert(4, ":").Insert(2, ":");
            lblStatus.Text = timeText;
        }

        private void bgwDownloader_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnBackup.Enabled = true;
            MessageBox.Show($"다운로드가 끝났습니다.");
            Close();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdDownload.ShowDialog() == DialogResult.OK)
                txtFolder.Text = fbdDownload.SelectedPath;
        }
    }
}