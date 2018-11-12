using System;

class Program
{
    static void Main()
    {
        double dollars = double.Parse(Console.ReadLine());

        double pounds = dollars * 1.31;

        string format = String.Format("{0:f3}", pounds);
        Console.WriteLine(format);
    }
}
