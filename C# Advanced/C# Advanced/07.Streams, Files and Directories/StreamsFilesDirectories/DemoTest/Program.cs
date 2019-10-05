using System;
using System.IO;

namespace DemoTest
{
    class Program
    {
        static void Main()
        {
            int counter = 1;
            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    writer.WriteLine($"Line {counter}");
                    counter++;
                }
            }
        }
    }
}
