#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Text.RegularExpressions;
using System.Web.Http;
using MahlerNo2.Api.Properties;
using MahlerNo2.Core.Components;
#endregion

namespace MahlerNo2.Api
{
    [Route("api/[controller]")]
    public class BackupController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get(string date)
        {
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(Settings.Default.ShotRoot, date));

            return directory.GetFiles("*" + Utility.ImageFileExtension)
                .OrderBy(x => x.Name)
                .Select(x => x.Name.Substring(7, 6))
                .ToList();
        }

        [HttpGet]
        public byte[] Get(string date, string time)
        {
            var fileName = $"{date}_{time}{Utility.ImageFileExtension}";

            return ControllerUtility.LoadFileWithCaching(date, fileName, Settings.Default.CacheTimeForBackup);
        }
    }
}