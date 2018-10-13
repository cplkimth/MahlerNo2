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

            btnN.Second = Settings.Default.NSecond;
            btnNN.Second = Settings.Default.NNSecond;
            btnNNN.Second = Settings.Default.NNNSecond;
            btnP.Second = Settings.Default.PSecond;
            btnPP.Second = Settings.Default.PPSecond;
            btnPPP.Second = Settings.Default.PPPSecond;

            _moveButtons = Controls.OfType<MoveButton>().ToList();

            foreach (var button in _moveButtons)
                toolTip.SetToolTip(button, button.ToolTipText);
        }

        private readonly List<MoveButton> _moveButtons;

        public DateTime Time => DateTime.ParseExact(mtbTime.Text, Utility.TimeFormat, null);

        public void ChangeTime(int second)
        {
            DateTime time = Time.AddSeconds(second);
            mtbTime.Text = time.ToString(Utility.TimeFormat);

            OnTimeChanged();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MoveButton button = (MoveButton) sender;
            
            ChangeTime(button.Second);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void btnRatio_Click(object sender, EventArgs e)
        {
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            OnOpacityChanging(false);
        }

        private void btnBrighten_Click(object sender, EventArgs e)
        {
            OnOpacityChanging(true);
        }

        #region TimeChanged event things for C# 3.0
        public event EventHandler<TimeChangedEventArgs> TimeChanged;

        protected virtual void OnTimeChanged(TimeChangedEventArgs e)
        {
            if (TimeChanged != null)
                TimeChanged(this, e);
        }

        private TimeChangedEventArgs OnTimeChanged()
        {
            TimeChangedEventArgs args = new TimeChangedEventArgs();
            OnTimeChanged(args);

            return args;
        }

/*private TimeChangedEventArgs OnTimeChangedForOut()
{
	TimeChangedEventArgs args = new TimeChangedEventArgs();
    OnTimeChanged(args);

    return args;
}*/

        public class TimeChangedEventArgs : EventArgs
        {
	

            /*public TimeChangedEventArgs()
            {
            }
            
            public TimeChangedEventArgs()
            {
                
            }*/
        }
        #endregion

        #region OpacityChanging event things for C# 3.0
        public event EventHandler<OpacityChangingEventArgs> OpacityChanging;

        protected virtual void OnOpacityChanging(OpacityChangingEventArgs e)
        {
            if (OpacityChanging != null)
                OpacityChanging(this, e);
        }

        private OpacityChangingEventArgs OnOpacityChanging(bool increasing)
        {
            OpacityChangingEventArgs args = new OpacityChangingEventArgs(increasing);
            OnOpacityChanging(args);

            return args;
        }

        private OpacityChangingEventArgs OnOpacityChangingForOut()
        {
            OpacityChangingEventArgs args = new OpacityChangingEventArgs();
            OnOpacityChanging(args);

            return args;
        }

        public class OpacityChangingEventArgs : EventArgs
        {
            public bool Increasing { get; set; }

            public OpacityChangingEventArgs()
            {
            }

            public OpacityChangingEventArgs(bool increasing)
            {
                Increasing = increasing;
            }
        }
        #endregion

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
            if (e.KeyCode == Keys.Enter && Regex.IsMatch(mtbTime.Text, TimeRegex))
                    OnTimeChanged();
        }
    }
}