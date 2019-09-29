using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    public class StartUp
    {
       public static void Main()
        {
            HashSet<string> cars = new HashSet<string>();
            
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] elements = line.Split(", ");
                string direction = elements[0];
                string car = elements[1];

                if (direction == "IN")
                {
                    cars.Add(car);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(car);
                }
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
