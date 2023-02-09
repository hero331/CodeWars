// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Diagnostics;
using System.Globalization;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i=2;i<40000;i++){
                Console.WriteLine($"Result: {i} = {PerfectPower.IsPerfectPower(i)}");
            }           
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}