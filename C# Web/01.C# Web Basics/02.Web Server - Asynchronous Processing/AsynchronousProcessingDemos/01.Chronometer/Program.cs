using System;
using System.Threading.Tasks;

namespace _01.Chronometer
{
    public class Program
    {
        public static void Main()
        {
            Chronometer chronometer = new Chronometer();

            while (true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "start":
                        Task.Run(() => chronometer.Start());
                        break;
                    case "lap":
                        Task.Run(() =>
                        {
                            chronometer.Lap();
                            Console.WriteLine(chronometer.GetTime);
                        });
                        break;
                    case "laps":
                        Task.Run(() =>
                        {
                            Console.WriteLine(chronometer.AllLaps());
                        });
                        break;
                    case "reset":
                        Task.Run(() =>
                        {
                            chronometer.Reset();
                        });
                        break;
                }
            }
        }
    }
}
