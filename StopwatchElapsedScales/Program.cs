using System;
using System.Diagnostics;
using System.Threading;

namespace StopwatchElapsedScales
{
    class Program
    {
        static void Main()
        {
            var sw = Stopwatch.StartNew();
            Thread.Sleep(100);
            sw.Stop();

            Console.WriteLine("Micro: " + sw.ElapsedMicroSeconds());
            Console.WriteLine("Nano : " + sw.ElapsedNanoSeconds());
            Console.WriteLine("Pico : " + sw.ElapsedPicoSeconds());

            Console.WriteLine();
        }
    }

    public static class StopwatchElapsedScales
    {
        static double _ticksPerSecond = Stopwatch.Frequency;

        static double _ticksPerMicro = _ticksPerSecond / Math.Pow(10, 6);
        static double _ticksPerNano = _ticksPerSecond  / Math.Pow(10, 9);
        static double _ticksPerPico = _ticksPerSecond  / Math.Pow(10, 12);

        public static double ElapsedMicroSeconds(this Stopwatch sw)
            => Math.Round(sw.ElapsedTicks / _ticksPerMicro, 0);

        public static double ElapsedNanoSeconds(this Stopwatch sw)
            => Math.Round(sw.ElapsedTicks / _ticksPerNano, 0);

        public static double ElapsedPicoSeconds(this Stopwatch sw)
            => Math.Round(sw.ElapsedTicks / _ticksPerPico, 0);
    }
}
