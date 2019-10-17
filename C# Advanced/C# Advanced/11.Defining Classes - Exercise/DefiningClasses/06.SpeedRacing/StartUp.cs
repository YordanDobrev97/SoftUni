using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int countOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < countOfCars; i++)
            {
                string[] carInputData = Console.ReadLine().Split();
                string model = carInputData[0];
                int fuelAmount = int.Parse(carInputData[1]);
                double fuelConsumptionFor1km = double.Parse(carInputData[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                string model = parts[1];
                double distance = double.Parse(parts[2]);

                var getCurrentCar = cars.Where(x => x.Model == model).ToList()[0];
                getCurrentCar.Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
