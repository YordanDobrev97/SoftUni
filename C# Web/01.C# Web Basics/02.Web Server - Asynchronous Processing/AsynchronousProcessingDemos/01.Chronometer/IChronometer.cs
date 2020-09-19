using System.Collections.Generic;

namespace _01.Chronometer
{
    public interface IChronometer
    {
        string GetTime { get; }

        List<string> Laps { get; }

        void Start();

        void Stop();

        void Lap();

        void Reset();
    }
}
