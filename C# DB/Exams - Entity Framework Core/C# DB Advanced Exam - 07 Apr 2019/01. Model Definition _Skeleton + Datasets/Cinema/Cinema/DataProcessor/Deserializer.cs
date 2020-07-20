namespace Cinema.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using Cinema.Data;
    using Cinema.Data.Models;
    using Cinema.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";
        private const string SuccessfulImportMovie 
            = "Successfully imported {0} with genre {1} and rating {2}!";
        private const string SuccessfulImportHallSeat 
            = "Successfully imported {0}({1}) with {2} seats!";
        private const string SuccessfulImportProjection 
            = "Successfully imported projection {0} on {1}!";
        private const string SuccessfulImportCustomerTicket 
            = "Successfully imported customer {0} {1} with bought tickets: {2}!";

        public static string ImportMovies(CinemaContext context, string jsonString)
        {
            StringBuilder bulder = new StringBuilder();

            var movies = JsonConvert.DeserializeObject<Movie[]>(jsonString);

            int count = 0;
            foreach (var obj in movies)
            {
                if (IsValid(obj))
                {
                    count++;
                    var movie = new Movie
                    {
                        Title = obj.Title,
                        Genre = obj.Genre,
                        Duration = obj.Duration,
                        Rating = obj.Rating,
                        Director = obj.Director
                    };

                    context.Movies.Add(movie);
                    bulder.AppendLine(String.Format(SuccessfulImportMovie, movie.Title, movie.Genre, movie.Rating.ToString("F2")));
                }
                else
                {
                    bulder.AppendLine(ErrorMessage);
                }
            }

            context.SaveChanges();

            return bulder.ToString();
        }

        public static string ImportHallSeats(CinemaContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            HallDTO[] seats = JsonConvert.DeserializeObject<HallDTO[]>(jsonString);

            foreach (var obj in seats)
            {
                if (IsValid(obj))
                {
                    var hall = new Hall
                    {
                        Name = obj.Name,
                        Is4Dx = obj.Is4Dx,
                        Is3D = obj.Is3D,
                    };

                    context.Halls.Add(hall);

                    var seat = new Seat
                    {
                        HallId = hall.Id,
                        Hall = hall
                    };

                    context.Seats.Add(seat);

                    hall.Seats.Add(seat);

                    sb.AppendLine(string.Format(SuccessfulImportHallSeat, ));
                }
            }

            context.SaveChanges();
            throw new NotImplementedException();
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validator, validationResult, true);
        }
    }
}