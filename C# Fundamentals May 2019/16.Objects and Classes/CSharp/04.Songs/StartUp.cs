using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Songs
{
    public class StartUp
    {
        public static void Main()
        {
            int numberSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberSongs; i++)
            {
                string[] informationPerSong = Console.ReadLine()
                    .Split('_');
                string type = informationPerSong[0];
                string name = informationPerSong[1];
                string time = informationPerSong[2];

                Song currentSong = new Song(type, name, time);
                songs.Add(currentSong);
            }

            string foundTypeSong = Console.ReadLine();
            var filterSong = songs;
            if (foundTypeSong != "all")
            {
                filterSong = songs.Where(x => x.Type == foundTypeSong).ToList();
            }
            
            foreach (var song in filterSong)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
