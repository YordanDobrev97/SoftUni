using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            int maxLongestSubSequence = 0;
            int indexOfMaxLongestSubSequence = 0;
            int longestIndexSequence = 1;
            int sumOfMaxLongestSubSequence = 0;

            string line = Console.ReadLine();
            int[] sequence = new int[length];

            int indexSequence = 1;

            while (line != "Clone them!")
            {
                int[] currentSequence = line.Split('!',
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentMaxSubSequence = 0;
                int currentIndex = 0;
                int currentSum = 0;
                int counter = 0;

                for (int i = 0; i < length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        counter++;
                        currentSum++;

                        if (counter > currentMaxSubSequence)
                        {
                            currentMaxSubSequence = counter;
                            currentIndex = i - counter;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }

                if (currentMaxSubSequence > maxLongestSubSequence)
                {
                    longestIndexSequence = indexSequence;
                    maxLongestSubSequence = currentMaxSubSequence;
                    indexOfMaxLongestSubSequence = currentIndex;
                    sumOfMaxLongestSubSequence = currentSum;
                    sequence = currentSequence;
                }
                else if (currentMaxSubSequence == maxLongestSubSequence
                    && indexOfMaxLongestSubSequence > currentIndex)
                {
                    longestIndexSequence = indexSequence;
                    indexOfMaxLongestSubSequence = currentIndex;
                    sumOfMaxLongestSubSequence = currentSum;
                    sequence = currentSequence;
                }
                else if (currentMaxSubSequence == maxLongestSubSequence
                    && indexOfMaxLongestSubSequence == currentIndex
                    && sumOfMaxLongestSubSequence > currentSum)
                {
                    longestIndexSequence = indexSequence;
                    sumOfMaxLongestSubSequence = currentSum;
                    sequence = currentSequence;
                }

                indexSequence++;
                line = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {longestIndexSequence} with sum: {sumOfMaxLongestSubSequence}.");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
