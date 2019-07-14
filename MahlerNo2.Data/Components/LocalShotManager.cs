using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MahlerNo2.Core.Components;

namespace MahlerNo2.Data.Components
{
    public class LocalShotManager : ShotManager
    {
        #region singleton
        private static LocalShotManager _instance;

        public static LocalShotManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LocalShotManager();
                return _instance;
            }
        }

        private LocalShotManager()
        {
            var parentDirectory = Path.GetTempPath();
            ShotRoot = Path.Combine(parentDirectory, Utility.ShotRootName);
        }
        #endregion

        public override byte[] Load(string date, string time)
        {
            var shotPath = Path.Combine(ShotRoot, date, time + Utility.ImageFileExtension);

            if (File.Exists(shotPath))
                return File.ReadAllBytes(shotPath);
            else
                return new byte[0];
        }
    }
}