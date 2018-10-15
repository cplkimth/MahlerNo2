using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MahlerNo2.Core.Components
{
    public static class Utility
    {
        public const string DateFormat = "yyMMdd";
        public const string TimeFormat = "HHmmss";
        public const string DateTimeFormat = DateFormat + "_" + TimeFormat;

        public const string ImageFileExtension = ".png";
        public const string NoteFileExtension = ".txt";

        public static string ToDateString(this DateTime dateTime) => dateTime.ToString(DateFormat);
        
        public static string ToTimeString(this DateTime dateTime) => dateTime.ToString(TimeFormat);


        public static string GetProductVersion()
        {
            var version = Assembly.GetEntryAssembly().GetName().Version;
            return $"{version.Major}.{version.Minor}.{version.Build}";
        }

        public static DateTime ToDateTime(this FileInfo file)
        {
            return DateTime.ParseExact(file.Name.Substring(0, 13), DateTimeFormat, null);
        }

        public static bool IsValidDate(this DirectoryInfo directory)
        {
            try
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                DateTime.ParseExact(directory.Name, DateFormat, null);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetShotFolderList(string rootPath)
        {
            DirectoryInfo root = new DirectoryInfo(rootPath);

            var query = from x in root.GetDirectories()
                where Regex.IsMatch(x.Name, "\\d{6}")
                select x.Name;

            return query.ToList();
        }

        public static string GetEarliestFileName(string rootPath, string date, string time)
        {
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(rootPath, date));

            string requestedFileName = $"{date}_{time}{Utility.ImageFileExtension}";

            var query = from x in directory.GetFiles("*" + Utility.ImageFileExtension)
                where x.Name.CompareTo(requestedFileName) <= 0
                select x.Name;

            return query.LastOrDefault();
        }
    }
}