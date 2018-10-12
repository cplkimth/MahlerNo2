#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MahlerNo2.Viewer.Controls;
using MahlerNo2.Viewer.Properties;
#endregion

namespace MahlerNo2.Viewer.Forms
{
    public partial class RemoconForm : Form
    {
        public RemoconForm()
        {
            InitializeComponent();

            btnFirst.Second = int.MinValue;
            btnLast.Second = int.MaxValue;
            btnN.Second = Settings.Default.NSecond;
            btnNN.Second = Settings.Default.NNSecond;
            btnNNN.Second = Settings.Default.NNNSecond;
            btnP.Second = Settings.Default.PSecond;
            btnPP.Second = Settings.Default.PPSecond;
            btnPPP.Second = Settings.Default.PPPSecond;

            Opacity = Settings.Default.Opacity;

            _moveButtons = Controls.OfType<MoveButton>().ToList();

            foreach (var button in _moveButtons)
                toolTip.SetToolTip(button, button.ToolTipText);
        }

        private readonly List<MoveButton> _moveButtons;

        private void btnMove_Click(object sender, EventArgs e)
        {
            int second = ((MoveButton) sender).Second;

            UpdateTime(second);
        }

        private DateTime Time
        {
            get
            {
                string timeText = DateTime.Today.ToString("yyyyMMdd") + lblTime.Text;
                return DateTime.ParseExact(timeText, "yyyyMMddHH:mm:ss", null);
            }
        }

        private void UpdateTime(int second)
        {
            DateTime time = Time;

            if (second == int.MaxValue)
                time = time.Date.Add(new TimeSpan(18, 0, 0));
            else if (second == Int32.MinValue)
                time = time.Date.Add(new TimeSpan(9, 0, 0));
            else
                time = time.AddSeconds(second);

            lblTime.Text = time.ToString("HH:mm:ss");
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.2)
                ChangeOpacity(-0.1);
        }

        private void btnBrighten_Click(object sender, EventArgs e)
        {
            if (Opacity < 1)
                ChangeOpacity(0.1);
        }

        private void ChangeOpacity(double delta)
        {
            Settings.Default.Opacity += delta;
            Opacity = Settings.Default.Opacity;
            Settings.Default.Save();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnRatio_Click(object sender, EventArgs e)
        {

        }
    }
}