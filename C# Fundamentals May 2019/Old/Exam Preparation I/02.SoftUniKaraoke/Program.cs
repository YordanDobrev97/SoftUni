using System;

namespace _02.SoftUniKaraoke
{
    class Program
    {
        static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var line = Console.ReadLine();

            while (line != "dawn")
            {
                var paramsInput = line.
                    Split(new[] {", "}, 
                        StringSplitOptions.RemoveEmptyEntries);


                line = Console.ReadLine();
            }
        }
    }
}
