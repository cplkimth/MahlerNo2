#region
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
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

            mtbTime.Text = DateTime.Now.ToString(Utility.TimeFormat);
        }

        public DateTime Time => DateTime.ParseExact(mtbTime.Text, Utility.TimeFormat, null);

        public void ChangeTime(int second)
        {
            DateTime time = Time.AddSeconds(second);
            mtbTime.Text = time.ToString(Utility.TimeFormat);
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
    }
}