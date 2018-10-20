using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        int sumPrimeNumbers = 0;
        int sumNotPrimeNumbers = 0;
        while (input != "stop")
        {
            int number = int.Parse(input);

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
                input = Console.ReadLine();
                continue;
            }

            if (IsPrime(number))
            {
                sumPrimeNumbers += number;
            }
            else
            {
                sumNotPrimeNumbers += number;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
        Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrimeNumbers}");
    }
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
