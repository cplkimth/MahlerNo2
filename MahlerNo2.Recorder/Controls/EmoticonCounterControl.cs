#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MahlerNo2.Core.Components;
using MahlerNo2.Core.Controls;
using MahlerNo2.Data;
using MahlerNo2.Recorder.Properties;
#endregion

namespace MahlerNo2.Recorder.Controls
{
    public partial class EmoticonCounterControl : BaseUserControl
    {
        public EmoticonCounterControl()
        {
            InitializeComponent();
        }

        private List<EmoticonCounterLineControl> _lines;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            _lines = new List<EmoticonCounterLineControl>
                                {
                                    usc어려워요,
                                    usc재밌어요,
                                    usc쉬고싶어요
                                };
        }

        public void RefreshCount()
        {
            var counts = DataRepository.Emoticon.GetLatest(Settings.Default.LatestEmoticonMinute);
            var names = Enum.GetNames(typeof(EmoticonType));
            foreach (var name in names)
                if (counts.ContainsKey(name) == false)
                    counts.Add(name, 0);

            foreach (var count in counts)
            {
                var line = _lines.Find(x => x.Emoticon.ToString() == count.Key);
                line.SetCount(count.Value);
            }
        }
    }
}