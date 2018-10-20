using System;
class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        string firstNumberAsString = firstNumber + "";

        if (firstNumberAsString.Length < 5 
            || secondNumber + "".Length < 5)
        {
            return;
        }

        while (firstNumber <=secondNumber)
        {
            //left
            int firstLeft = firstNumberAsString[0] - '0';
            int secondLeft = firstNumberAsString[1] - '0';

            //middle digit
            int middle = firstNumberAsString[2] - '0';

            //right
            int firstRight = firstNumberAsString[3] - '0';
            int secondRight = firstNumberAsString[4] - '0';

            int leftSum = firstLeft + secondLeft;
            int rightSum = firstRight + secondRight;

            if (leftSum == rightSum)
            {
                Console.Write($"{firstLeft}{secondLeft}{middle}{firstRight}{secondRight} ");
            }
            else
            {
                bool isLeftSumMin = leftSum < rightSum;
                if (isLeftSumMin)
                {
                    leftSum += middle;
                }
                else
                {
                    rightSum += middle;
                }

                if (leftSum == rightSum)
                {
                    Console.Write($"{firstLeft}{secondLeft}{middle}{firstRight}{secondRight} ");
                }
            }

            firstNumber++;
            firstNumberAsString = firstNumber + "";
        }
        Console.WriteLine();
    }
}

