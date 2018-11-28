using System;

class Program
{
    static int steps = 0;
    static void Main()
    {
        int n = 5;
        int fibonacii = Fibonacii(n);
        Console.WriteLine($"Fibonacii from {n} is : {fibonacii}");
        Console.WriteLine($"Numbers of steps: {steps}");
    }
    static int Fibonacii(int number)
    {
        if (number <= 1)
        {
            steps++;
            return 1;
        }
        else
        {
            steps++;
            return Fibonacii(number - 2) + Fibonacii(number - 1);
        }
    }
}

