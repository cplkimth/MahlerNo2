using System;
using System.IO;
using System.Reflection;

namespace MahlerNo2.Core.Components
{
    public static class Utility
    {
        public const string DateFormat = "yyMMdd";
        public const string TimeFormat = "HHmmss";
        public const string DateTimeFormat = DateFormat + "_" + TimeFormat;

        public const string ImageFileExtension = ".png";
        public const string NoteFileExtension = ".txt";

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
    }
}