using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    public class Crossroads
    {
        public static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            bool isTrashed = false;
            int succesfulCount = 0;
            while (input != "END")
            {
                if (input == "green")
                {
                    int currentGreenLight = greenLight;
                    while (currentGreenLight > 0 && cars.Count > 0)
                    {
                        string currentCar = cars.Dequeue();
                        int lengthOfCar = currentCar.Length;

                        if (currentGreenLight - lengthOfCar > 0 
                            && currentGreenLight - lengthOfCar <= currentGreenLight )
                        {
                            currentGreenLight -= lengthOfCar;
                        }
                        else
                        {
                            int left = currentGreenLight - lengthOfCar;

                            if (left > 0)
                            {
                                currentGreenLight -= lengthOfCar;
                            }
                            else
                            {
                                if (freeWindow - -left >= 0)
                                {
                                    freeWindow -= -left;
                                    currentGreenLight -= lengthOfCar;
                                }
                                else
                                {
                                    isTrashed = true;
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar[currentGreenLight + freeWindow]}.");
                                    break;
                                }
                            }
                        }

                        succesfulCount++;
                    }
                }
                else
                {
                    cars.Enqueue(input); // add current car
                }

                if (isTrashed)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (!isTrashed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{succesfulCount} total cars passed the crossroads.");
            }
        }
    }
}
