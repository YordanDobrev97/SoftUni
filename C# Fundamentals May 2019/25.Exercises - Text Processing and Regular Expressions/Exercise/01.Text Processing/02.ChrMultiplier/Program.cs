using System;

namespace _02.ChrMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split();

            string firstWord = words[0];
            string secondWord = words[1];

            long totalSum = 0;

            int min = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < min; i++)
            {
                long symbolFirstWord = firstWord[i];
                long symbolSecondWord = secondWord[i];

                long product = symbolFirstWord * symbolSecondWord;
                totalSum += product;
            }

            if (firstWord.Length < secondWord.Length)
            {
                int remainder = secondWord.Length - firstWord.Length;

                for (int i = firstWord.Length; i <=remainder; i++)
                {
                    totalSum += secondWord[i];
                }
            }
            else if (firstWord.Length > secondWord.Length)
            {
                int remainder = firstWord.Length - secondWord.Length;

                for (int i = secondWord.Length; i <= remainder; i++)
                {
                    totalSum += firstWord[i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}