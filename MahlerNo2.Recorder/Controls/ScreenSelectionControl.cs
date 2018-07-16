using System;
using System.Windows.Forms;
using MahlerNo2.Core.Controls;
using MahlerNo2.Recorder.Components;

namespace MahlerNo2.Recorder.Controls
{
    public partial class ScreenSelectionControl : BaseUserControl
    {
        private Screen _screen;

        public ScreenSelectionControl()
        {
            InitializeComponent();
        }

        public void LoadScreenImage(Screen screen)
        {
            _screen = screen;
            var bitmap = ScreenShotTaker.Instance.Shot(_screen);
            ptbScreen.Image = bitmap;
        }

        private void ptbScreen_DoubleClick(object sender, EventArgs e)
        {
            OnScreenSelected(_screen);
        }

        #region ScreenSelected event things for C# 3.0

        public event EventHandler<ScreenSelectedEventArgs> ScreenSelected;

        protected virtual void OnScreenSelected(ScreenSelectedEventArgs e)
        {
            if (ScreenSelected != null)
                ScreenSelected(this, e);
        }

        private ScreenSelectedEventArgs OnScreenSelected(Screen screen)
        {
            var args = new ScreenSelectedEventArgs(screen);
            OnScreenSelected(args);

            return args;
        }

        private ScreenSelectedEventArgs OnScreenSelectedForOut()
        {
            var args = new ScreenSelectedEventArgs();
            OnScreenSelected(args);

            return args;
        }

        public class ScreenSelectedEventArgs : EventArgs
        {
            public ScreenSelectedEventArgs()
            {
            }

            public ScreenSelectedEventArgs(Screen screen)
            {
                Screen = screen;
            }

            public Screen Screen { get; set; }
        }

        #endregion
    }
}