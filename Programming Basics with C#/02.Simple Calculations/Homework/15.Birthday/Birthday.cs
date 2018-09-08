using System;

namespace _15.Birthday
{
    class Birthday
    {
        static void Main()
        {
            int lengthInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heigthInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            percent *= 0.01;

            double volume = lengthInCm * widthInCm * heigthInCm;
            double totalLitters = volume * 0.001;

            double result = totalLitters - (totalLitters *percent);
            Console.WriteLine($"{result:f3}");
        }
    }
}
