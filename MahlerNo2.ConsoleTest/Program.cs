using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MahlerNo2.Viewer.Components;

namespace MahlerNo2.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = ApiClient.Instance.GetDateList();
            var bytes = ApiClient.Instance.GetShot("181013", "100000");
        }
    }
}
