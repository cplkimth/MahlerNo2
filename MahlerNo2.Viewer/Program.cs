#region using

using System;
using System.Windows.Forms;

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

            Application.Run(new Form1());
        }

        public static bool OnRunTime { get; private set; }
    }
}