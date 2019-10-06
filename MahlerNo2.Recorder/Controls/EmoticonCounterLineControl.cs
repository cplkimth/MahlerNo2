#region
using System;
using System.ComponentModel;
using System.Drawing;
using MahlerNo2.Core.Components;
using MahlerNo2.Core.Controls;
using MahlerNo2.Recorder.Properties;
#endregion

namespace MahlerNo2.Recorder.Controls
{
    public partial class EmoticonCounterLineControl : BaseUserControl
    {
        public EmoticonCounterLineControl()
        {
            InitializeComponent();
        }

        [DefaultValue(EmoticonType.어려워요)]
        public EmoticonType Emoticon { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            uscRater.CurrentRating = Settings.Default.MaxRating;
            ptbImage.Image = (Image) Resources.ResourceManager.GetObject(Emoticon.ToString());
        }

        public void SetCount(int count)
        {
            uscRater.CurrentRating = count;
        }
    }
}