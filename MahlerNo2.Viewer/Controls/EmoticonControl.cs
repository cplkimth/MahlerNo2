#region
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Core.Controls;
using MahlerNo2.Data;
using MahlerNo2.Viewer.Properties;
#endregion

namespace MahlerNo2.Viewer.Controls
{
    public partial class EmoticonControl : BaseUserControl
    {
        public EmoticonControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            ptbImage.Image = (Image) Resources.ResourceManager.GetObject(Emoticon.ToString());
            toolTip.SetToolTip(ptbImage, Emoticon.ToString());
        }

        [DefaultValue(EmoticonType.어려워요)]
        public EmoticonType Emoticon { get; set; }

        private const int MaxCoolTime = 60 * 10;

        private int _elapsedSecond;

        private void ptbImage_Click(object sender, EventArgs e)
        {
            Emoticon emoticon = new Emoticon { At = DateTime.Now, Name = Emoticon.ToString()};
            DataRepository.Emoticon.Insert(emoticon);

            ptbImage.Enabled = false;
            ptbImage.Image = (Image) Resources.ResourceManager.GetObject(Emoticon + "_gray");

            _elapsedSecond = 0;
            Timer coolTimer = new Timer();
            coolTimer.Interval = 100;
            coolTimer.Tick += CoolTimer_Tick;
            coolTimer.Start();
        }

        private void CoolTimer_Tick(object sender, EventArgs e)
        {
            _elapsedSecond++;

            prbCoolTime.Value = (int) (_elapsedSecond * 100.0 / MaxCoolTime);

            if (_elapsedSecond == MaxCoolTime)
            {
                Timer coolTimer = (Timer) sender;
                coolTimer.Stop();
                coolTimer.Dispose();

                ptbImage.Enabled = true;
                ptbImage.Image = (Image) Resources.ResourceManager.GetObject(Emoticon.ToString());
                prbCoolTime.Value = 0;
            }
        }
    }
}