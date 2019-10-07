using System;
using System.Collections.Generic;
using System.Linq;

namespace MahlerNo2.Data
{
    public partial class EmoticonData
    {
        public virtual Dictionary<string, int> GetLatest(int minute)
        {
            using (var context = DbContextFactory.Create())
            {
                var to = DateTime.Now;
                var from = DateTime.Now.AddMinutes(minute * -1);

                var query = from x in context.Emoticons
                            //where x.At >= @from && x.At <= to
                            group x by x.Name into g
                            select g;


                return query.ToDictionary(x => x.Key, x => x.Count());
            }
        }

    }
}