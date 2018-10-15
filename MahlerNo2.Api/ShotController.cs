#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Caching;
using System.Web.Http;
using MahlerNo2.Api.Properties;
using MahlerNo2.Core.Components;
#endregion

namespace MahlerNo2.Api
{
    [Route("api/[controller]")]
    public class ShotController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Utility.GetShotFolderList(Settings.Default.ShotRoot);
        }

        [HttpGet]
        public byte[] Get(string date, string time)
        {
            var fileName = Utility.GetEarliestFileName(Settings.Default.ShotRoot, date, time);

            return ControllerUtility.LoadFileWithCaching(date, fileName, Settings.Default.CacheTimeForRequest);
        }
    }
}