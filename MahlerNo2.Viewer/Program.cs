#region using

using System;
using System.Windows.Forms;
using MahlerNo2.Viewer.Forms;

#endregion

namespace MahlerNo2.Viewer
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OnRunTime = true;

//            Application.Run(new MainForm());
            Application.Run(new ViewerFormEx(new DateTime(2018,10,12)));
//            Application.Run(new RemoconForm());
        }

        public static bool OnRunTime { get; private set; }
    }
}