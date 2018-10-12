using System.Windows.Forms;

namespace MahlerNo2.Viewer.Controls
{
    public class MoveButton : Button
    {
        public int Second { get; set; }

        public string ToolTipText
        {
            get
            {
                if (Second == int.MaxValue)
                    return "Last";
                else if (Second == int.MinValue)
                    return "First";
                else if (Second > 60)
                    return $"{Second / 60}M";
                else
                    return $"{Second}S";
            }
        }

    }
}