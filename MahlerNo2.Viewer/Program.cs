#region using

using System;
using System.Windows.Forms;
using MahlerNo2.Viewer.Forms;

#endregion

namespace MahlerNo2.Viewer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IsRunTime = true;

//            Application.Run(new MainForm());
            Application.Run(new BackupForm(new DateTime(2018,7,17)));
//            Application.Run(new ShotForm2(new DateTime(2018,10,12)));
//            Application.Run(new RemoconForm());
        }

        public static bool IsRunTime { get; private set; }

        internal static bool OfflineMode { get; set; }
    }
}