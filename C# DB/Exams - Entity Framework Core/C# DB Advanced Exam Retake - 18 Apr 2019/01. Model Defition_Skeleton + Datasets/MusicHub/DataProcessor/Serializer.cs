namespace MusicHub.DataProcessor
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;
    using MusicHub.DataProcessor.ExportDtos;
    using Newtonsoft.Json;
    using XmlFacade;

    public class Serializer
    {
        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albums = context.Albums
                 .Where(a => a.ProducerId == producerId)
                 .OrderByDescending(a => a.Songs.Sum(s => s.Price))
                 .Select(a => new 
                 {
                     AlbumName = a.Name,
                     ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                     ProducerName = a.Producer.Name,
                     Songs = a.Songs
                         .Select(s => new 
                         {
                             SongName = s.Name,
                             Price = s.Price.ToString("F2"),
                             Writer = s.Writer.Name
                         })
                         .OrderByDescending(s => s.SongName)
                         .ThenBy(s => s.Writer)
                         .ToArray(),
                     AlbumPrice = a.Songs.Sum(s => s.Price).ToString("F2")
                 })
                 .ToArray();

            string jsonExport = JsonConvert.SerializeObject(albums, Formatting.Indented);

            return jsonExport;
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(s => new ExportSongDurationDTO
                {
                    SongName = s.Name,
                    Writer = s.Writer.Name,
                    Performer = s.SongPerformers.Select(sp => sp.Performer.FirstName + " " +         sp.Performer.LastName).FirstOrDefault(),

                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration.ToString("c", CultureInfo.InvariantCulture)
                })
                .OrderBy(s => s.SongName)
                .ThenBy(s => s.Writer)
                .ThenBy(s => s.Performer)
                .ToArray();

            var xml = XmlConverter.Serialize(songs, "Songs");
            return xml;
        }
    }
}