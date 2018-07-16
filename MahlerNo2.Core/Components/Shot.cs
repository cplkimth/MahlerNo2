using System;

namespace MahlerNo2.Core.Components
{
    public class Shot
    {
        public Shot(DateTime time)
        {
            Time = time;
            Note = string.Empty;
        }

        public DateTime Time { get; }

        public string Note { get; set; }
    }
}