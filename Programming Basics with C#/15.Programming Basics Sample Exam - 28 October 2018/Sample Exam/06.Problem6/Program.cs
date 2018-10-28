using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int lastDigit = number % 10;
        number /= 10;
        int middleDigit = number % 10;
        number /= 10;
        int firstDigit = number % 10;

        for (int first = 1; first <=lastDigit; first++)
        {
            for (int second = 1; second <= middleDigit; second++)
            {
                for (int third = 1; third <= firstDigit; third++)
                {
                    Console.WriteLine($"{first} * {second} * {third} = {first * second * third};");
                }
            }
        }
    }
}

