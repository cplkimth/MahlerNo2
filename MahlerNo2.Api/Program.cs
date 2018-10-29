#region
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using MahlerNo2.Api.Properties;
using Microsoft.Owin.Hosting;
#endregion

namespace MahlerNo2.Api
{
    class Program
    {
        protected internal const int MinPort = 80;
        protected internal const int MaxPort = 65535;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Mahler No.2 API server의 설정은 아래와 같습니다.");
            
                Console.WriteLine($"IP : {Settings.Default.IP}");
                Console.WriteLine($"포트 : {Settings.Default.Port}");
                Console.WriteLine($"저장폴더 : {Settings.Default.ShotRoot}");

                Console.WriteLine("이 설정대로 실행할까요? (Y/n)");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                    ConfigSetting();
                else
                    break;
            }

            Console.WriteLine("Mahler No.2 API server is running. press any key to stop.");

            using (WebApp.Start<Startup>($"http://{Settings.Default.IP}:{Settings.Default.Port}/"))
            {
                Console.ReadLine();
            }
        }

        private static void ConfigSetting()
        {
            ConfigIP();

            ConfigPort();

            ConfigShotRoot();

            Settings.Default.Save();
        }

        private static void ConfigShotRoot()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Mahler No.2의 스크린샷이 저장될 폴더를 입력하세요. (기본값 D:\\MahlerNo2_Shots)");

                string input = Console.ReadLine();
                if (input.Length == 0)
                    input = "D:\\MahlerNo2_Shots";

                if (Directory.Exists(input) == false)
                    continue;

                if (input.EndsWith("\\") == false)
                    input += "\\";

                Settings.Default.ShotRoot = input;
                break;
            }
        }

        private static void ConfigPort()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"포트를 입력하세요. ({MinPort} ~ {MaxPort})");

                string input = Console.ReadLine();

                bool parsed = int.TryParse(input, out int port);

                if (parsed == false || port < MinPort || port > MaxPort)
                    continue;

                Settings.Default.Port = port;
                break;
            }
        }

        private static void ConfigIP()
        {
            var addresses = Dns.GetHostEntry(Dns.GetHostName()).AddressList
                .Where(x => x.AddressFamily == AddressFamily.InterNetwork)
                .Select(x => x.ToString())
                .ToList();

            for (int i = 0; i < addresses.Count; i++)
                Console.WriteLine($"[{i + 1}] {addresses[i]}");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"IP를 선택하세요. (1 ~ {addresses.Count})");

                string input = Console.ReadLine();

                bool parsed = int.TryParse(input, out int index);
                
                if (parsed == false || index < 1 || index > addresses.Count)
                    continue;

                Settings.Default.IP = addresses[index - 1];
                break;
            }
        }
    }
}