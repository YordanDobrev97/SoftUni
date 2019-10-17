using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int countEngine = int.Parse(Console.ReadLine());

            List<Engine> listEngines = new List<Engine>();
            for (int i = 0; i < countEngine; i++)
            {
                string[] engineItems = Console.ReadLine()
                    .Split();

                string model = engineItems[0];
                int power = int.Parse(engineItems[1]);
                if (engineItems.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    listEngines.Add(engine);
                }
                else if (engineItems.Length == 3)
                {
                    bool hasDisplacement = int.TryParse(engineItems[2], out int displacement);

                    Engine engine = null;
                    if (hasDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineItems[2]);
                    }
                    
                    listEngines.Add(engine);
                }
                else if (engineItems.Length == 4)
                {
                    int displacement = int.Parse(engineItems[2]);
                    string efficiency = engineItems[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    listEngines.Add(engine);
                }
            }

            int countCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < countCars; i++)
            {
                string[] carItems = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carItems[0];
                string engine = carItems[1];

                Engine engine1 = listEngines.Where(x => x.Model == engine).FirstOrDefault();

                if (carItems.Length == 2)
                {
                    Car car = new Car(model, engine1);
                    cars.Add(car);
                }
                else if (carItems.Length == 3)
                {
                    bool hasWeight = int.TryParse(carItems[2], out int weight);
                    Car car = null;
                    if (hasWeight)
                    {
                        car = new Car(model, engine1, weight);
                    }
                    else
                    {
                        string color = carItems[2];
                        car = new Car(model, engine1, color);
                    }
                    cars.Add(car);
                }
                else if (carItems.Length == 4)
                {
                    int weight = int.Parse(carItems[2]);
                    string color = carItems[3];

                    Car car = new Car(model, engine1, weight, color);
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == 0)
                {
                    Console.WriteLine("  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
