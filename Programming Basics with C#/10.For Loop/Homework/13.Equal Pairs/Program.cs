using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber;

        int maxDiff = 0;
        for (int i = 0; i < number - 1; i++)
        {
            int firstCurrentNumber = int.Parse(Console.ReadLine());
            int secondCurrentNumber = int.Parse(Console.ReadLine());

            int currentSum = firstCurrentNumber + secondCurrentNumber;
            if (currentSum == sum)
            {
                continue;
            }
            else
            {
                var diff = Math.Abs(sum - currentSum);
                if (currentSum != 0 && diff >=maxDiff)
                {
                    maxDiff += diff;
                }
            }
        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
