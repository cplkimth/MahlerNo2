#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
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
            _directory = Path.Combine(Settings.Default.ShotRoot, DateText);
        }

        private readonly DateTime _date;

        private readonly string _directory;

        private string _dateText;

        private List<string> _times;

        public string DateText => _dateText ?? (_dateText = _date.ToDateString());

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            Directory.CreateDirectory(_directory);

            _times = ApiClient.Instance.GetFileNamesInDate(DateText);

            txtFolder.Text = _directory;
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
            List<string> times = (List<string>) e.Argument;

            int count = 0;

            foreach (var time in times)
            {
                count++;

                string filePath = Path.Combine(_directory, $"{DateText}_{time}{Utility.ImageFileExtension}");

                if (File.Exists(filePath) == false)
                {
                    var bytes = ApiClient.Instance.GetShotForBackup(_date.ToDateString(), time);
                    File.WriteAllBytes(filePath, bytes);
                }
                    
                bgwDownloader.ReportProgress(count, filePath);
            }
        }

        private void bgwDownloader_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            prbProgress.Value = e.ProgressPercentage;

            lblStatus.Text = (string) e.UserState;
        }

        private void bgwDownloader_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnBackup.Enabled = true;
            MessageBox.Show($"다운로드가 끝났습니다.\n다운로드한 파일은 아래 위치에 저장되어 있습니다.\n\n{_directory}");
            Close();
        }
    }
}