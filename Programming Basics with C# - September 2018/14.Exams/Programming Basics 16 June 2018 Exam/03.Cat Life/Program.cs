using System;

namespace _03.Cat_Life
{
    class Program
    {
        static void Main()
        {
            string breed = Console.ReadLine();
            char genderCat = char.Parse(Console.ReadLine());

            int yearsCat = 0;
            switch (breed)
            {
                case "British Shorthair":
                    if (genderCat == 'm')
                    {
                        yearsCat = 13;
                    }
                    else
                    {
                        yearsCat = 14;
                    }
                    break;
                case "Siamese":
                    if (genderCat == 'm')
                    {
                        yearsCat = 15;
                    }
                    else
                    {
                        yearsCat = 16;
                    }
                    break;
                case "Persian":
                    if (genderCat == 'm')
                    {
                        yearsCat = 14;
                    }
                    else
                    {
                        yearsCat = 15;
                    }
                    break;
                case "Ragdoll":
                    if (genderCat == 'm')
                    {
                        yearsCat = 16;
                    }
                    else
                    {
                        yearsCat = 17;
                    }
                    break;
                case "American Shorthair":
                    if (genderCat == 'm')
                    {
                        yearsCat = 12;
                    }
                    else
                    {
                        yearsCat = 13;
                    }
                    break;
                case "Siberian":
                    if (genderCat == 'm')
                    {
                        yearsCat = 11;
                    }
                    else
                    {
                        yearsCat = 12;
                    }
                    break;
                default:
                    Console.WriteLine($"{breed} is invalid cat!");
                    return;
            }
            Console.WriteLine($"{yearsCat * 12 / 6} cat months");
        }
    }
}
