using System;
using System.Collections.Generic;
using System.Linq;

class Statistic
{
    public Statistic(string nameArtist, string nameSong, int views)
    {
        this.NameArtist = nameArtist;
        this.NameSong = nameSong;
        this.Views = views;
        this.Likes = 0;
    }

    public string NameArtist { get; set; }

    public string NameSong { get; set; }

    public int Views { get; set; }

    public int Likes { get; set; }

}

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();

        var songsArtistsViews = new Dictionary<string, List<Statistic>>();

        while (line != "stats time")
        {
            string[] paramsLine = line.Split(new[] {'-', ':' },
                StringSplitOptions.RemoveEmptyEntries);

            var elementsLine = paramsLine[0].Split();
            if (elementsLine[0] == "like")
            {
                string nameArtist = paramsLine[1].Split()[0];
                string nameSong = paramsLine[1].Split()[1];

                if (songsArtistsViews.ContainsKey(nameArtist))
                {
                    songsArtistsViews.Values.
                        FirstOrDefault(x => x[0].NameSong == nameSong)[0].Likes++;
                }
            }
            else if (elementsLine[0] == "dislike")
            {
                string nameArtist = paramsLine[1].Split()[0];
                string nameSong = paramsLine[1].Split()[1];

                if (songsArtistsViews.ContainsKey(nameArtist))
                {
                    songsArtistsViews.Values.
                        FirstOrDefault(x => x[0].NameSong == nameSong)[0].Likes--;
                }
            }
            else
            {
                if (elementsLine.Length > 2)
                {
                    elementsLine[0] = elementsLine[0] + " " + elementsLine[1];
                    elementsLine[1] = elementsLine[2];
                }
                string nameArtist = elementsLine[0];
                string nameSong = elementsLine[1];
                int views = int.Parse(paramsLine.Last());

                if (!songsArtistsViews.ContainsKey(nameArtist))
                {
                    Statistic currentStatistic = new Statistic(nameArtist, nameSong, views);
                    var list = new List<Statistic>();
                    list.Add(currentStatistic);
                    songsArtistsViews.Add(nameArtist, list);
                }
                else
                {
                    var getNameSong = songsArtistsViews.Values.ToList()[0];

                    if (getNameSong[0].NameSong == nameSong)
                    {
                        getNameSong[0].Views += views;
                    }
                    else
                    {
                        var newSong = new Statistic(nameArtist, nameSong, views);
                        getNameSong.Add(newSong);
                    }

                }
            }

            line = Console.ReadLine();
        }

        string typeOrder = Console.ReadLine();

        if (typeOrder == "by likes")
        {
            var orderLikes = songsArtistsViews.Values.OrderByDescending(x => x[0].Likes);
            Print(orderLikes);
        }
        else
        {
            var orderViews = songsArtistsViews.Values.OrderByDescending(x => x[0].Views);
            Print(orderViews);
        }
    }

    private static void Print(IOrderedEnumerable<List<Statistic>> orderLikes)
    {
        foreach (var item in orderLikes)
        {
            Console.WriteLine($"{item[0].NameArtist} " +
                $"{item[0].NameSong} - {item[0].Views} views - {item[0].Likes} likes");
        }
    }
}

