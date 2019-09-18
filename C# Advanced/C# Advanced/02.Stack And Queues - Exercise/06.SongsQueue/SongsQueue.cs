using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class SongsQueue
    {
        static void Main()
        {
            string[] songInput = Console.ReadLine()
                .Split(", ");

            Queue<string> songs = new Queue<string>(songInput);

            while (songs.Count > 0)
            {
                string input = Console.ReadLine();

                if (input.Contains("Add"))
                {
                    string song = input.Substring(4);

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (input.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
