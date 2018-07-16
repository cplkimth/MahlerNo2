using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MahlerNo2.Viewer.Properties;

namespace MahlerNo2.Viewer.Controls
{
    public partial class TimePicker : UserControl
    {
        public TimePicker()
        {
            InitializeComponent();
        }

        private DateTime _previous;

        private PlayImage _playImage = PlayImage.Play;

        public DateTime From { get; private set; }

        public DateTime To { get; private set; }

        public void SetRange(DateTime from, DateTime to)
        {
            From = from;
            To = to;

            _previous = From;
            dtpTime.Value = From;

            ChangeFont();
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            dtpTime.ValueChanged -= dtpTime_ValueChanged;

            if (_previous.Second == 59 && dtpTime.Value.Second == 00)
                dtpTime.Value = dtpTime.Value.AddMinutes(1);
            else if (_previous.Second == 0 && dtpTime.Value.Second == 59)
                dtpTime.Value = dtpTime.Value.AddMinutes(-1);
            else if (_previous.Minute == 59 && dtpTime.Value.Minute == 00)
                dtpTime.Value = dtpTime.Value.AddHours(1);
            else if (_previous.Minute == 0 && dtpTime.Value.Minute == 59)
                dtpTime.Value = dtpTime.Value.AddHours(-1);

            _previous = dtpTime.Value;

            dtpTime.ValueChanged += dtpTime_ValueChanged;

            OnTimeChanged(Time);

            ChangeFont();
        }

        private void ChangeFont()
        {
            if (dtpTime.Value >= From && dtpTime.Value <= To)
                dtpTime.ResetFont();
            else
                dtpTime.Font = new Font(dtpTime.Font, FontStyle.Strikeout);
        }

        public string Time => dtpTime.Value.ToString(dtpTime.CustomFormat);

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_playImage == PlayImage.Play)
            {
                btnPlay.BackgroundImage = Resources.Pause;
                _playImage = PlayImage.Pause;
                tmrTimer.Start();
            }
            else
            {
                btnPlay.BackgroundImage = Resources.Play;
                _playImage = PlayImage.Play;
                tmrTimer.Stop();
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            dtpTime.Value = dtpTime.Value.AddSeconds(1);

            if (dtpTime.Font.Strikeout)
                tmrTimer.Stop();
            else
                OnSecondElapsed(Time);
        }

        private enum PlayImage
        {
            Play,
            Pause
        }

        #region TimeChanged event things for C# 3.0
        public event EventHandler<TimeChangedEventArgs> TimeChanged;

        protected virtual void OnTimeChanged(TimeChangedEventArgs e)
        {
            if (TimeChanged != null)
                TimeChanged(this, e);
        }

        private TimeChangedEventArgs OnTimeChanged(string time )
        {
            TimeChangedEventArgs args = new TimeChangedEventArgs(time );
            OnTimeChanged(args);

            return args;
        }

        private TimeChangedEventArgs OnTimeChangedForOut()
        {
            TimeChangedEventArgs args = new TimeChangedEventArgs();
            OnTimeChanged(args);

            return args;
        }

        public class TimeChangedEventArgs : EventArgs
        {
            public string Time { get; set;} 

            public TimeChangedEventArgs()
            {
            }
	
            public TimeChangedEventArgs(string time )
            {
                Time = time; 
            }
        }
        #endregion

        #region SecondElapsed event things for C# 3.0
        public event EventHandler<SecondElapsedEventArgs> SecondElapsed;

        protected virtual void OnSecondElapsed(SecondElapsedEventArgs e)
        {
            if (SecondElapsed != null)
                SecondElapsed(this, e);
        }

        private SecondElapsedEventArgs OnSecondElapsed(string time )
        {
            SecondElapsedEventArgs args = new SecondElapsedEventArgs(time );
            OnSecondElapsed(args);

            return args;
        }

        private SecondElapsedEventArgs OnSecondElapsedForOut()
        {
            SecondElapsedEventArgs args = new SecondElapsedEventArgs();
            OnSecondElapsed(args);

            return args;
        }

        public class SecondElapsedEventArgs : EventArgs
        {
            public string Time { get; set;} 

            public SecondElapsedEventArgs()
            {
            }
	
            public SecondElapsedEventArgs(string time )
            {
                Time = time; 
            }
        }
        #endregion

        private void btnSeconds_Click(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(((Button) sender).Text);
            dtpTime.Value = dtpTime.Value.AddSeconds(seconds);
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            var text = ((Button) sender).Text;

        }
    }
}
