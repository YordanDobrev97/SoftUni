using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace _01.Chronometer
{
    public class Chronometer : IChronometer
    {
        private Stopwatch timer;

        public Chronometer()
        {
            this.timer = new Stopwatch();
            this.Laps = new List<string>();
        }

        public string GetTime { get; private set; }

        public List<string> Laps { get; private set; }

        public void Lap()
        {
            this.GetTime = this.timer.Elapsed.ToString();
            this.Laps.Add(this.GetTime);
        }

        public void Reset()
        {
            this.GetTime = this.timer.ToString();
            this.Stop();
            this.Laps.Clear();
        }

        public void Start()
        {
            this.timer.Start();
        }

        public void Stop()
        {
            this.timer.Stop();
        }

        public string AllLaps()
        {
            Thread.Sleep(5000);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Laps:");

            for (int i = 0; i < this.Laps.Count; i++)
            {
                sb.AppendLine($"{i}: {this.Laps[i]}");
            }

            return sb.ToString();
        }
    }
}
