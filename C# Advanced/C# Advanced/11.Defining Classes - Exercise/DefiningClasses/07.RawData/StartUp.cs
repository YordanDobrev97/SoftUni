using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int countCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < countCars; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = elements[0];
                int engineSpeed = int.Parse(elements[1]);
                int enginePower = int.Parse(elements[2]);
                int cargoWeight = int.Parse(elements[3]);
                string cargoType = elements[4];

                double tire1Pressure = double.Parse(elements[5]);
                int tire1Age = int.Parse(elements[6]);
                double tire2Pressure = double.Parse(elements[7]);
                int tire2Age = int.Parse(elements[8]);
                double tire3Pressure = double.Parse(elements[9]);
                int tire3Age = int.Parse(elements[10]);
                double tire4Pressure = double.Parse(elements[11]);
                int tire4Age = int.Parse(elements[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4]
                {
                    new Tire(tire1Pressure, tire1Age),
                    new Tire(tire2Pressure, tire2Age),
                    new Tire(tire3Pressure, tire3Age),
                    new Tire(tire4Pressure, tire4Age),
                };
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var result = cars.Where(x => x.Cargo.CargoType == "fragile")
                .Where(x => x.Tires.Any(p => p.TirePressure < 1))
                .ToList();

                foreach (var item in result)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                var result = cars.Where(x => x.Cargo.CargoType == "flamable")
                    .Where(x => x.Engine.EnginePower > 250)
                    .ToList();

                foreach (var item in result)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
