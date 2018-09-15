using System;

namespace _11.Say_Hello
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            SayHello(name);
        }
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
