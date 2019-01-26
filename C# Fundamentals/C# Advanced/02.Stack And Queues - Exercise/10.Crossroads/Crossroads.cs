using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    public class Crossroads
    {
        public static void Main()
        {
            int durationGreenLight = int.Parse(Console.ReadLine());
            int durationFreeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int carsDuration = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{carsDuration} total cars passed the crossroads.");
                    break;
                }

                if (command == "green")
                {
                    int currentDuration = durationGreenLight;
                    while (cars.Count > 0)
                    {
                        string currentCar = cars.Peek();
                        int duration = cars.Dequeue().Length;

                        if (duration < currentDuration)
                        {
                            carsDuration++;
                            currentDuration -= duration;
                        }
                        else if(duration - currentDuration < durationFreeWindow)
                        {
                            if (duration > durationFreeWindow)
                            {
                                break;
                            }
                            durationFreeWindow -= duration - currentDuration;
                            carsDuration++;
                        }
                        else
                        {
                            int indexCrash = currentDuration + durationFreeWindow;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[indexCrash]}.");
                            return;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
        }
    }
}
