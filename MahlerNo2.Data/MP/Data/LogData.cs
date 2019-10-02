using System;
using System.Text;

namespace MahlerNo2.Data
{
    public partial class LogData
    {
        public void Write(Exception ex, string category = "")
        {
            StringBuilder builder = new StringBuilder(ex.ToString());

            Log log = new Log();
            log.At = DateTime.Now;
            log.Category = category;

            if (ex.InnerException != null)
            {
                builder.AppendLine();
                builder.AppendLine("-------------------------------------------");
                builder.AppendLine();
            }

            log.Text = builder.ToString();

            Insert(log);
        }
    }
}