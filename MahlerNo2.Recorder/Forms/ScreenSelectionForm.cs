using System;
using System.Windows.Forms;
using MahlerNo2.Recorder.Components;
using MahlerNo2.Recorder.Controls;

namespace MahlerNo2.Recorder.Forms
{
    public partial class ScreenSelectionForm : RecorderBaseForm
    {
        public ScreenSelectionForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            uscLeftScreen.LoadScreenImage(Screen.AllScreens[0]);
            uscRightScreen.LoadScreenImage(Screen.AllScreens[1]);
        }

        private void uscScreenSelector_ScreenSelected(object sender, ScreenSelectionControl.ScreenSelectedEventArgs e)
        {
            ScreenShotTaker.Instance.Screen = e.Screen;

            Close();
        }
    }
}