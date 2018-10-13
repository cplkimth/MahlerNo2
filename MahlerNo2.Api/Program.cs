#region
using System;
using System.Net.Http;
using MahlerNo2.Api.Properties;
using Microsoft.Owin.Hosting;
#endregion

namespace MahlerNo2.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mahler No.2 API server is running. press any key to stop.");
            using (WebApp.Start<Startup>($"http://{Settings.Default.IP}:{Settings.Default.Port}/"))
            {
                Console.ReadLine();
            }
        }
    }
}