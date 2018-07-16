using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahlerNo2.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Keys.TryParse("-", out Keys key);
            Console.WriteLine(key);
        }
    }
}
