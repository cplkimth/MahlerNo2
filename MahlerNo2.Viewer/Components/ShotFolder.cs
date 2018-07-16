using System;

namespace MahlerNo2.Viewer.Components
{
    public class ShotFolder
    {
        public ShotFolder(string folder)
        {
            Folder = folder;
        }

        public string Folder { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public int FileCount { get; set; }
    }
}