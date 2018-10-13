#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Text.RegularExpressions;
using System.Web.Http;
using MahlerNo2.Api.Properties;
#endregion

namespace MahlerNo2.Api
{
    [Route("api/[controller]")]
    public class ShotController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            DirectoryInfo root = new DirectoryInfo(Settings.Default.ShotRoot);

            var query = from x in root.GetDirectories()
                where Regex.IsMatch(x.Name, "\\d{6}")
                select x.Name;

            return query.ToList();
        }

        [HttpGet()]
        public string Get(string date)
        {
            DirectoryInfo directory = new DirectoryInfo(Settings.Default.ShotRoot + date);

            return directory.GetFiles("*.png").Select(x => x.Name).LastOrDefault();
        }

        [HttpGet()]
        public byte[] Get(string date, string time)
        {
            DirectoryInfo directory = new DirectoryInfo(Settings.Default.ShotRoot + date);

            string requestedFileName = $"{date}_{time}.png";

            var query = from x in directory.GetFiles("*.png")
                where x.Name.CompareTo(requestedFileName) <= 0
                select x.Name;

            var fileName = query.LastOrDefault();

            if (MemoryCache.Default.Contains(fileName))
            {
                return (byte[]) MemoryCache.Default[fileName];
            }
            else
            {
                var filePath = $"{Settings.Default.ShotRoot}{date}\\{fileName}";
                var bytes = File.ReadAllBytes(filePath);
                MemoryCache.Default.Add(fileName, bytes, new DateTimeOffset(DateTime.Now.AddSeconds(Settings.Default.CacheSecond)));

                return bytes;
            }
        }
    }
}