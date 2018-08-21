using System;

namespace _07.Measuring_Units
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double mm = 1000.0;
            double cm = 100.0;
            double mi = 0.000621371192;
            double inn = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;
            double m = 1.0;

            if (input == "mm")
            {
                number = number / mm;
            }
            else if(input == "cm")
            {
                number = number / cm;
            }
            else if(input == "mi")
            {
                number = number / mi;
            }
            else if(input == "in")
            {
                number = number / inn;
            }
            else if(input == "km")
            {
                number = number / km;
            }
            else if(input == "ft")
            {
                number = number / ft;
            }
            else if(input == "yd")
            {
                number = number / yd;
            }
            else
            {
                number = number / m;
            }


            if (output == "mm")
            {
                number = number * mm;
            }
            else if (output == "cm")
            {
                number = number * cm;
            }
            else if (output == "mi")
            {
                number = number * mi;
            }
            else if (output == "in")
            {
                number = number * inn;
            }
            else if (output == "km")
            {
                number = number * km;
            }
            else if (output == "ft")
            {
                number = number * ft;
            }
            else if (output == "yd")
            {
                number = number * yd;
            }
            else
            {
                number = number / m;
            }

            Console.WriteLine($"{number:f8}");
        }
    }
}
