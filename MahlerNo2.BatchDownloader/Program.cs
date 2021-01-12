using MahlerNo2.Data;
using MahlerNo2.Data.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahlerNo2.BatchDownloader
{
    class Program
    {
        private const string Root = @"C:\sync\603R\MahlerNo2 Backup";

        static void Main(string[] args)
        {
            var dates = DataRepository.Shot.GetDateList();

            foreach (var date in dates)
            {
                Console.WriteLine($"[{date}]");
                DownloadForDate(date);
                Console.WriteLine();
            }
        }

        private static void DownloadForDate(string date)
        {

            string directory = Path.Combine(Root, date);

            if (Directory.Exists(directory) == false)
                Directory.CreateDirectory(directory);

            List<DateTime> times = DataRepository.Shot.LoadForDate(date);

            foreach (var time in times)
            {
                string timeText = time.ToTimeString();

                var image = DataRepository.Shot.SelectFirst(x => x.At == time, x => x.Data);

                string path = Path.Combine(directory, timeText + ".png");

                File.WriteAllBytes(path, image);
                
                Console.Write('.');
            }
        }
    }
}
