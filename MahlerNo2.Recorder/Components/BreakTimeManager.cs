using System;
using System.Collections.Generic;
using MahlerNo2.Data;
using MahlerNo2.Recorder.Properties;

namespace MahlerNo2.Recorder.Components
{
    public class BreakTimeManager
    {
        #region singleton
        private static BreakTimeManager _instance;

        public static BreakTimeManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BreakTimeManager();
                return _instance;
            }
        }

        private BreakTimeManager()
        {
            _breakTimes = DataRepository.BreakTime.Get();
        }
        #endregion

        private readonly List<BreakTime> _breakTimes;

        public string GetBreakTimeText()
        {
            DateTime at = DateTime.Now.AddMinutes(Settings.Default.BreakTimeAlarm);

//            var breakTime = _breakTimes.Find(x => x.At.Hour == at.Hour && x.At.Minute == at.Minute);
            var breakTime = _breakTimes[0];

            if (breakTime == null)
                return null;

            return $"{Settings.Default.BreakTimeAlarm} 분 후 {breakTime.No} 교시가 종료됩니다.";
        }
    }
}