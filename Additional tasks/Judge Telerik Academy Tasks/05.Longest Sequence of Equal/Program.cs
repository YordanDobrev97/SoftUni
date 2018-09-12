using System;

namespace _05.Longest_Sequence_of_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = int.Parse(Console.ReadLine());

            int[] elements = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                int number = int.Parse(Console.ReadLine());
                elements[i] = number;
            }

            int counter = 1;
            int numberCommon = 0;
            int currentCounter = 1;

            bool notComeEnd = false;

            int index = 0;
            while (!notComeEnd)
            {
                int currentElement = elements[index];
                int nextElement = elements[index + 1];

                if (currentElement == nextElement)
                {
                    currentCounter++;
                }
                else
                {
                    if (currentCounter > counter)
                    {
                        counter = currentCounter;
                        numberCommon = currentElement;
                    }
                    currentCounter = 1;
                }
                index++;
                if (index >= elements.Length - 1)
                {
                    notComeEnd = true;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
