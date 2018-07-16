using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MahlerNo2.Recorder.Forms;

namespace MahlerNo2.Recorder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OnRunTime = true;

            Application.Run(new MainForm());
        }

        public static bool OnRunTime { get; private set; }
    }
}
