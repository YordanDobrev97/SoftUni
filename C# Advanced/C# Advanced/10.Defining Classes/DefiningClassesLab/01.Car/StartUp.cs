namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "No more tires")
                {
                    break;
                }

                double[] informationForTires = line.Split()
                    .Select(double.Parse)
                    .ToArray();

                Tire[] currentTires = new Tire[4]
                {
                    new Tire((int)informationForTires[0], informationForTires[1]),
                    new Tire((int)informationForTires[2], informationForTires[3]),
                    new Tire((int)informationForTires[4], informationForTires[5]),
                    new Tire((int)informationForTires[6], informationForTires[7])
                };

                tires.Add(currentTires);
            }

            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Engines done")
                {
                    break;
                }

                string[] engineData = line.Split();
                int horsePower = int.Parse(engineData[0]);
                double cubicCapacity = double.Parse(engineData[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Show special")
                {
                    break;
                }

                string[] carData = line.Split();
                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tiresIndex = int.Parse(carData[6]);

                Engine engine = engines[engineIndex];
                Tire[] currentTires = tires[tiresIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, currentTires);
                cars.Add(car);
            }

            var specialCars = cars.Where(x => x.Year >= 2017
            && x.Engine.HorsePower > 330
            && x.Tires.Select(c => c.Pressure).Sum() >= 9
            && x.Tires.Select(c => c.Pressure).Sum() <= 10)
                .ToList();

            foreach (var car in specialCars)
            {
                car.Drive(20);
                Console.WriteLine(car.ToString());
            }
        }
    }
}