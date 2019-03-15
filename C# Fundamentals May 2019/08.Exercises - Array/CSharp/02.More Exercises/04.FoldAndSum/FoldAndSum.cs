using System;
using System.Linq;
namespace _04.FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers =
                Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int[] middleElements = GetMiddleElements(numbers);
            int[] frontElemetns = GetFrontElements(numbers);
            int[] backElements = GetBackElements(numbers);

            int[] concatFrontBackElements = ConcatFrontBackElements(frontElemetns, backElements);
            int[] sumArray = SumArray(middleElements, concatFrontBackElements);
            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static int[] SumArray(int[] middleElements, int[] concatFrontBackElements)
        {
            int[] sumArray = new int[middleElements.Length];

            for (int i = 0; i < sumArray.Length; i++)
            {
                int firstArrayElement = middleElements[i];
                int secondArrayElement = concatFrontBackElements[i];
                int sum = firstArrayElement + secondArrayElement;
                sumArray[i] = sum;
            }

            return sumArray;
        }

        private static int[] ConcatFrontBackElements(int[] frontElemetns,
            int[] backElements)
        {
            int[] newConcatElements = new int[frontElemetns.Length + backElements.Length];

            int index = 0;
            for (int i = 0; i < frontElemetns.Length; i++)
            {
                newConcatElements[index] = frontElemetns[i];
                index++;
            }

            for (int i = 0; i < backElements.Length; i++)
            {
                newConcatElements[index] = backElements[i];
                index++;
            }

            return newConcatElements;
        }

        private static int[] GetBackElements(int[] numbers)
        {
            int lengthMiddleElements = numbers.Length / 2;
            int lengthFrontElements = numbers.Length / 4;

            int[] backElements = new int[lengthFrontElements];
            int index = 0;
            for (int i = lengthMiddleElements + lengthFrontElements;
                i < numbers.Length; i++)
            {
                backElements[index] = numbers[i];
                index++;
            }

            return backElements.Reverse().ToArray();
        }

        private static int[] GetFrontElements(int[] numbers)
        {
            int[] frontElements = new int[numbers.Length / 4];

            for (int i = 0; i < frontElements.Length; i++)
            {
                frontElements[i] = numbers[i];
            }

            return frontElements.Reverse().ToArray();
        }

        public static int[] GetMiddleElements(int[] array)
        {
            int[] resultArray = new int[array.Length / 2];

            int index = 0;
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[index] = array[resultArray.Length / 2 + i];
                index++;
            }

            return resultArray;
        }
    }
}
