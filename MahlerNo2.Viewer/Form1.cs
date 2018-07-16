using System;
using System.Drawing;
using System.Windows.Forms;
using MahlerNo2.Viewer.Components;
using MahlerNo2.Viewer.Controls;

namespace MahlerNo2.Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

            BackgroundImage =
                Image.FromFile(@"D:\sync\pc\screenshot\Sopranos\Episode 01 - The Sopranos.mkv_20180622_203543.538.jpg");

            uscTime.SetRange(DateTime.Today.AddMinutes(1), DateTime.Today.AddMinutes(2).AddSeconds(30));
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.LeaveFullScreenMode();
        }

        private void uscTime_TimeChanged(object sender, TimePicker.TimeChangedEventArgs e)
        {
            Text = e.Time;
        }
    }
}