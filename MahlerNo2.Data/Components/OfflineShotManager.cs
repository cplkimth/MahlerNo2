using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MahlerNo2.Data.Components
{
    public class OfflineShotManager : ShotManager
    {
        #region singleton
        private static OfflineShotManager _instance;

        public static OfflineShotManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OfflineShotManager();
                return _instance;
            }
        }

        private OfflineShotManager()
        {
            var parentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ShotRoot = Path.Combine(parentDirectory, Utility.ShotRootName);

            if (Directory.Exists(ShotRoot) == false)
                Directory.CreateDirectory(ShotRoot);
        }
        #endregion

        private List<OfflineShot> _shots;

        public void SetDate(string date)
        {
            var directoryForDate = GetDirectoryForDate(date);
            _shots = Directory.GetFiles(directoryForDate)
                        .OrderBy(x => x)
                        .Select(x => new OfflineShot
                          {
                              Time = Path.GetFileNameWithoutExtension(x),
                              Data = File.ReadAllBytes(x)
                          })
                        .ToList();
        }

        public override byte[] Load(string date, string time)
        {
            for (int i = 0; i < _shots.Count - 1; i++)
            {
                if (
                    time.CompareTo(_shots[i].Time) >= 0 && 
                    time.CompareTo(_shots[i+1].Time) < 0)
                    return _shots[i].Data;
            }

            if (_shots.Count > 0)
                return _shots[_shots.Count - 1].Data;

            return new byte[0];
        }

        public List<string> GetDateList()
        {
            DirectoryInfo root = new DirectoryInfo(ShotRoot);

            var query = from x in root.GetDirectories()
                where Regex.IsMatch(x.Name, "\\d{6}")
                orderby x.Name descending 
                select x.Name;

            return query.ToList();
        }

        class OfflineShot
        {
            public string Time { get; set; }
            public byte[] Data { get; set; }
        }
    }
}
