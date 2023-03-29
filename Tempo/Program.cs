using System;
using System.Diagnostics;
using System.Threading;
 
namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(300);
            crono1.Stop();
            crono2.Stop();

            float time1 = (float)crono1.ElapsedMilliseconds;
            float time2 = (float)crono2.ElapsedMilliseconds;

            time1 /= 1000;
            time2 /= 1000;
            

            Console.WriteLine($"Stopwatch 1's measured time lapse: {time1:f2}");
            Console.WriteLine($"Stopwatch 2's measured time lapse: {time2:f2}");
        }
    }
}
