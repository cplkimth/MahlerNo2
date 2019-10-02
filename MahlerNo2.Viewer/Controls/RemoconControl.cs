#region
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Data.Components;
using MahlerNo2.Viewer.Properties;
#endregion

namespace MahlerNo2.Viewer.Controls
{
    public partial class RemoconControl : UserControl
    {
        private const string TimeRegex = @"^(?:(?:([01]?\d|2[0-3]))?([0-5]?\d))?([0-5]?\d)$";

        public RemoconControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            if (Program.OfflineMode)
            {
                ptbOnline.Image = Resources.Off;
                btnBackup.Visible = false;
            }

            mtbTime.Text = DateTime.Now.ToTimeString();
        }

        public DateTime Time => DateTime.ParseExact(mtbTime.Text, Utility.TimeFormat, null);

        public void ChangeTime(int second)
        {
            DateTime time = Time.AddSeconds(second);
            mtbTime.Text = time.ToTimeString();
        }

        private void mtbTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !Regex.IsMatch(mtbTime.Text, TimeRegex);

            if (e.Cancel)
                mtbTime.BackColor = Color.Red;
            else
                mtbTime.BackColor = Color.Beige;
        }

        private void mtbTime_KeyUp(object sender, KeyEventArgs e)
        {
//            if (e.KeyCode == Keys.Enter && Regex.IsMatch(mtbTime.Text, TimeRegex))
//                    OnTimeChanged();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            OnBackupClicked();
        }

        #region BackupClicked event things for C# 3.0
        public event EventHandler<BackupClickedEventArgs> BackupClicked;

        protected virtual void OnBackupClicked(BackupClickedEventArgs e)
        {
            if (BackupClicked != null)
                BackupClicked(this, e);
        }

        private BackupClickedEventArgs OnBackupClicked()
        {
            BackupClickedEventArgs args = new BackupClickedEventArgs();
            OnBackupClicked(args);

            return args;
        }

/*private BackupClickedEventArgs OnBackupClickedForOut()
{
	BackupClickedEventArgs args = new BackupClickedEventArgs();
    OnBackupClicked(args);

    return args;
}*/

        public class BackupClickedEventArgs : EventArgs
        {
	

            /*public BackupClickedEventArgs()
            {
            }
            
            public BackupClickedEventArgs()
            {
                
            }*/
        }
        #endregion
    }
}