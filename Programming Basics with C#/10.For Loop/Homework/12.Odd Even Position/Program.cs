using System;
class Program
{
    static bool isOddPosition(int position)
    {
        return position % 2 == 1;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;

        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        for (int i = 1; i <=number; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());

            if (isOddPosition(i))
            {
                oddSum += currentNumber;
            }
            else
            {
                evenSum += currentNumber;
            }

            if (isOddPosition(i) && oddMin > currentNumber)
            {
                oddMin = currentNumber;
            }
            else if(!isOddPosition(i) && evenMin > currentNumber)
            {
                evenMin = currentNumber;
            }

            if (isOddPosition(i) && oddMax < currentNumber)
            {
                oddMax = currentNumber;
            }
            else if(!isOddPosition(i) && evenMax < currentNumber)
            {
                evenMax = currentNumber;
            }

        }
        Console.WriteLine("OddSum={0},", oddSum);
        Console.WriteLine("OddMin={0},", oddMin == double.MaxValue ? "No" : $"{oddMin}");
        Console.WriteLine("OddMax={0},", oddMax == double.MinValue ? "No" : $"{oddMax}");

        Console.WriteLine("EvenSum={0},", evenSum);
        Console.WriteLine("EvenMin={0}", evenMin == double.MaxValue ? "No": $"{evenMin}");
        Console.WriteLine("EvenMax={0}", evenMax == double.MinValue ? "No": $"{evenMax}");
    }
}

