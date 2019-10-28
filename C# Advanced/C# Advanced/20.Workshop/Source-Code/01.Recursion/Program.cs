namespace _01.Recursion
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
        }

        private static int A()
        {
            return B();
        }

        private static int B()
        {
            return A();
        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        private static int SumArray(int[] myArray, int index)
        {
            if (index < myArray.Length)
            {
                return myArray[index] + SumArray(myArray, index + 1);
            }

            return 0;

            //if (index == myArray.Length)
            //{
            //    return 0;
            //}

            //int currentValue = myArray[index];
            //int nextValue = SumArray(myArray, index + 1);

            //int result = currentValue + nextValue;

            //return result;
        }

        public static void Recursion(int a)
        {
            a += 1;

            if (a == 10)
            {
                return;
            }

            Console.WriteLine($"Pre-Action: {a}");

            Recursion(a);

            Console.WriteLine($"Post-Action: {a}");
        }
    }
}