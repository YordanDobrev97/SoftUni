using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            //Arithmetic operators
            int a = 10;
            int b = 20;

            int sum = a + b;//30
            int subtraction = a - b;//-10
            int multiply = a * b; // 200
            int divider = a / b; //0
            int remainder = a % b;//10

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Subtraction: {0}", subtraction);
            Console.WriteLine("Multiply: {0}", multiply);
            Console.WriteLine("Divider: {0}", divider);
            Console.WriteLine("Remainder: {0}", remainder);

            //Relational operators
            bool isEqual = a == b;//Fale
            bool diff = a != b;// True
            bool bigger = a > b;//False
            bool smaller = a < b;//True

            //Logical operators
            bool isEven = a % 2 == 0;
            bool isOdd = b % 2 == 1;

            bool isEqualEven = isEven && isOdd;//False 
            bool isEqualEvenLeast = isEven || isOdd;// True

            //Bitwise operators
            a = 5;
            b = 6;

            int bitwiseAnd = a & b; // 4
            int bitwiseOr = a | b;//7
            int bitwiseHor = a ^ b;//3
            int bitwiseUnaryNot = ~a;//-6
            int bitwiseLeft = a << 1;//10
            int bitwiseRight = a >> 2;//1
            
        }
    }
}
