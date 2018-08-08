using System;
class TrapeziodArea
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        double area = (firstNumber + secondNumber) * thirdNumber / 2;
        Console.WriteLine(area);
    }
}

