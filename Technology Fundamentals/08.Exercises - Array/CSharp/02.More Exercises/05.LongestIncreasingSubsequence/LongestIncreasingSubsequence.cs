using System;
using System.Collections.Generic;

namespace _05.LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] numbers = { 7, 3, 5, 8, -1, 0, 6, 7 };
            //int[] numbers = { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };

            List<int> increasingSubsequence = new List<int>();
            // 3, 5, 12
            increasingSubsequence.Add(numbers[0]);

            for (int i = 1; i < numbers.Length; i++)
            {
                int element = numbers[i];
                int lengthIncreasing = increasingSubsequence.Count;
                for (int j = 0; j < lengthIncreasing; j++)
                {
                    if (j > increasingSubsequence.Count - 1)
                    {
                        break;
                    }
                    int subsequenceElement = increasingSubsequence[j];
                    if (subsequenceElement < element)
                    {
                        if (!(increasingSubsequence.Contains(element)))
                        {
                            increasingSubsequence.Add(element);
                        }
                    }
                    else
                    {
                        while (!(increasingSubsequence[j] <= element))
                        {
                            if (increasingSubsequence.Count > 0 && j < increasingSubsequence.Count - 1)
                            {
                                increasingSubsequence.RemoveAt(j);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", increasingSubsequence));
        }
    }
}
