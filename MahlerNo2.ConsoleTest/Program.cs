#region
using System;
using System.IO;
using MahlerNo2.Data;
#endregion

namespace MahlerNo2.ConsoleTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var directory = Path.GetDirectoryName(@"C:\Users\thkim\Documents\MahlerNo2\190713.txt");
            Directory.CreateDirectory(directory);
            File.WriteAllText(@"C:\Users\thkim\Documents\MahlerNo2\190713.txt", "abc");

            Console.WriteLine(DataRepository.Shot.GetCount());
            return;
            DataRepository.Shot.GetDateList().ForEach(x => Console.WriteLine(x));

            var shot = DataRepository.Shot.Load("190108", "190148");
            Console.WriteLine(shot.Length);
        }
    }
}