using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            RaceMotorcycle race = new RaceMotorcycle(300, 100);

            race.Drive(10);
            Console.WriteLine(race.Fuel);
        }
    }
}
