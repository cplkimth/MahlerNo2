using System;
using System.IO;
using System.Runtime.Caching;
using MahlerNo2.Api.Properties;

namespace MahlerNo2.Api
{
    public class ControllerUtility
    {
        public static byte[] LoadFileWithCaching(string date, string fileName, int cacheTime)
        {
            if (MemoryCache.Default.Contains(fileName))
            {
                return (byte[]) MemoryCache.Default[fileName];
            }
            else
            {
                var filePath = Path.Combine(Settings.Default.ShotRoot, date, fileName);
                var bytes = File.ReadAllBytes(filePath);
                MemoryCache.Default.Add(fileName, bytes, new DateTimeOffset(DateTime.Now.AddSeconds(cacheTime)));

                return bytes;
            }
        }
    }
}