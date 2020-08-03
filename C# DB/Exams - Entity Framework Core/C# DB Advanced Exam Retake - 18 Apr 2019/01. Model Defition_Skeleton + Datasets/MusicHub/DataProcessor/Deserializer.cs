namespace MusicHub.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Microsoft.EntityFrameworkCore.Internal;
    using Microsoft.EntityFrameworkCore.Storage;
    using MusicHub.Data.Models;
    using MusicHub.Data.Models.Enums;
    using MusicHub.DataProcessor.ImportDtos;
    using Newtonsoft.Json;
    using XmlFacade;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data";

        private const string SuccessfullyImportedWriter 
            = "Imported {0}";
        private const string SuccessfullyImportedProducerWithPhone 
            = "Imported {0} with phone: {1} produces {2} albums";
        private const string SuccessfullyImportedProducerWithNoPhone
            = "Imported {0} with no phone number produces {1} albums";
        private const string SuccessfullyImportedSong 
            = "Imported {0} ({1} genre) with duration {2}";
        private const string SuccessfullyImportedPerformer
            = "Imported {0} ({1} songs)";

        public static string ImportWriters(MusicHubDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var data = JsonConvert.DeserializeObject<ImportWriterDTO[]>(jsonString);

            foreach (var item in data)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var writer = new Writer
                {
                    Name = item.Name,
                    Pseudonym = item.Pseudonym
                };

                context.Writers.Add(writer);
                sb.AppendLine(string.Format(SuccessfullyImportedWriter, writer.Name));
            }

            context.SaveChanges();

            return sb.ToString();
        }

        public static string ImportProducersAlbums(MusicHubDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var data = JsonConvert.DeserializeObject<ImportProducerAlbumDTO[]>(jsonString);

            foreach (var item in data)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var producure = new Producer
                {
                    Name = item.Name,
                    Pseudonym = item.Pseudonym,
                    PhoneNumber = item.PhoneNumber,
                };

                var isImported = true;
                foreach (var albumsDTO in item.Albums)
                {
                    if (!IsValid(albumsDTO))
                    {
                        isImported = false;
                        sb.AppendLine(ErrorMessage);
                        break;
                    }

                    var album = new Album
                    {
                        Name = albumsDTO.Name,
                        ReleaseDate = DateTime.ParseExact(albumsDTO.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    };

                    producure.Albums.Add(album);
                }

                //invalid album not add producer
                if (!isImported)
                {
                    continue;
                }

                context.Producers.Add(producure);

                if (producure.PhoneNumber == null)
                {
                    sb.AppendLine(string.Format(SuccessfullyImportedProducerWithNoPhone, producure.Name, producure.Albums.Count));
                }
                else
                {
                    sb.AppendLine(string.Format(SuccessfullyImportedProducerWithPhone, producure.Name, producure.PhoneNumber, producure.Albums.Count));
                }
            }

            context.SaveChanges();
            return sb.ToString();
        }

        public static string ImportSongs(MusicHubDbContext context, string xmlString)
        {
            //XmlConverter is helper class
            var root = "Songs";
            var data = XmlConverter.Deserializer<ImportSongDTO>(xmlString, root);

            StringBuilder sb = new StringBuilder();

            foreach (var item in data)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (item.AlbumId == null || !context.Albums.Any(a => a.Id == item.AlbumId))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!context.Writers.Any(w => w.Id == item.WriterId))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                //invalid genre
                Genre genre;
                var validGenre = Enum.TryParse<Genre>(item.Genre.ToString(), out genre);

                if (!validGenre)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var song = new Song
                {
                    Name = item.Name,
                    CreatedOn = DateTime.ParseExact(item.CreatedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Duration = TimeSpan.Parse(item.Duration),
                    Price = item.Price,
                    Genre = genre,
                    AlbumId = item.AlbumId,
                    WriterId = item.WriterId
                };

                context.Songs.Add(song);
                sb.AppendLine(string.Format(SuccessfullyImportedSong, song.Name, song.Genre, song.Duration));
            }

            context.SaveChanges();
            return sb.ToString();
        }

        public static string ImportSongPerformers(MusicHubDbContext context, string xmlString)
        {
            var root = "Performers";
            var data = XmlConverter.Deserializer<ImportSongPerformerDTO>(xmlString, root);

            StringBuilder sb = new StringBuilder();

            foreach (var item in data)
            {
                if (!IsValid(item))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var performer = new Performer
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Age = item.Age,
                    NetWorth = item.NetWorth
                };

                bool isValidPerformer = true;
                foreach (var performerSong in item.PerformersSongs)
                {
                    if (!IsValid(performerSong) || !context.Songs.Any(s => s.Id == performerSong.Id))
                    {
                        isValidPerformer = false;
                        sb.AppendLine(ErrorMessage);
                        break;
                    }

                    var ps = new SongPerformer
                    {
                        PerformerId = performer.Id,
                        SongId = performerSong.Id
                    };

                    performer.PerformerSongs.Add(ps);
                }

                if (!isValidPerformer)
                {
                    continue;
                }

                context.Performers.Add(performer);
                sb.AppendLine(string.Format(SuccessfullyImportedPerformer, performer.FirstName, performer.PerformerSongs.Count));
            }

            context.SaveChanges();
            return sb.ToString();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}