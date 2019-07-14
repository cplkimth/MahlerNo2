using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace MahlerNo2.Data.Components
{
    public abstract class ShotManager
    {
        public string ShotRoot { get; protected set; }

        public string GetDirectoryForDate(string date)
        {
            return Path.Combine(ShotRoot, date);
        }

        public abstract byte[] Load(string date, string time);

        public void Save(string date, string time, byte[] image)
        {
            var dateDirectory = GetDirectoryForDate(date);

            if (Directory.Exists(dateDirectory) == false)
                Directory.CreateDirectory(dateDirectory);

            var shotPath = Path.Combine(dateDirectory, time + Utility.ImageFileExtension);
            
            if (File.Exists(shotPath))
                return;

            File.WriteAllBytes(shotPath, image);
        }
    }
}