#region
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using MahlerNo2.Data.Components;
#endregion

namespace MahlerNo2.Data
{
    public partial class ShotData
    {
        public void Save(byte[] data, string note)
        {
            var shot = new Shot();
            var at = DateTime.Now;
            shot.At = new DateTime(at.Year, at.Month, at.Day, at.Hour, at.Minute, at.Second);
            shot.Data = data;
            shot.Note = note;

            Insert(shot);
        }

        public List<string> GetDateList()
        {
            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.Shots
                            group x by DbFunctions.TruncateTime(x.At) into g
                            orderby g.Key descending
                            select g.Key;

                var dates = query.ToList();
                return dates.ConvertAll(x => x.Value.ToString(Utility.DateFormat));
            }
        }

        public byte[] Load(string date, string time)
        {
            var localImage = LocalShotManager.Instance.Load(date, time);

            if (localImage.Length != 0)
                return localImage;

            var dateTimeText = Utility.BuildDateTimeText(date, time);
            var dateTime = DateTime.ParseExact(dateTimeText, Utility.DateTimeFormat, null);

            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.Shots
                            where x.At <= dateTime
                            orderby x.At descending
                            select x.Data;

                var image = query.FirstOrDefault() ?? new byte[0];

                LocalShotManager.Instance.Save(date, time, image);

                return image;
            }
        }

        public List<DateTime> LoadForDate(string dateText)
        {
            var theDay = DateTime.ParseExact(dateText, Utility.DateFormat, null);
            var nextDay = theDay.AddDays(1);

            using (var context = DbContextFactory.Create())
            {
                var query = from x in context.Shots
                            where x.At >= theDay && x.At < nextDay
                            orderby x.At
                            select x.At;

                return query.ToList();
            }
        }
    }
}