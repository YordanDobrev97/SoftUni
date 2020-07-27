namespace Cinema.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Cinema.Data;
    using Cinema.Data.Models;
    using Cinema.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using XmlFacade;

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
            HallDTO[] data = JsonConvert.DeserializeObject<HallDTO[]>(jsonString);
            List<Hall> halls = new List<Hall>();

            foreach (var item in data)
            {
                if (IsValid(item))
                {
                    var hall = new Hall
                    {
                        Name = item.Name,
                    };

                    string typeProjection = "Normal";
                    if (item.Is3D)
                    {
                        hall.Is3D = item.Is3D;
                        typeProjection = "3D";
                    }

                    if (item.Is4Dx)
                    {
                        hall.Is4Dx = item.Is4Dx;
                        typeProjection = "4Dx";
                    }

                    if (item.Is3D && item.Is4Dx)
                    {
                        typeProjection = "4Dx/3D";
                    }

                    for (int i = 0; i < item.Seats; i++)
                    {
                        hall.Seats.Add(new Seat
                        {
                            Hall = hall,
                        });
                    }

                    halls.Add(hall);
                    sb.AppendLine(string.Format(SuccessfulImportHallSeat, hall.Name, typeProjection, item.Seats));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }
            int totalSeats = halls.Sum(h => h.Seats.Count);

            context.Halls.AddRange(halls);
            context.SaveChanges();
            return sb.ToString();
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {
            var root = "Projections";
            var data = XmlConverter.Deserializer<ProjectionDTO>(xmlString, root);

            List<Projection> projections = new List<Projection>();
            StringBuilder sb = new StringBuilder();

            foreach (var projectionDTO in data)
            {
                var projection = new Projection
                {
                    MovieId = projectionDTO.MovieId,
                    HallId = projectionDTO.HallId,
                    DateTime = DateTime.ParseExact(projectionDTO.DateTime, "yyyy-MM-dd H:mm:ss", CultureInfo.InvariantCulture)
                };

                var movieTitle = context.Movies.FirstOrDefault(m => m.Id == projection.MovieId);
                var hall = context.Halls.FirstOrDefault(h => h.Id == projection.HallId);

                if (movieTitle == null || hall == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                projections.Add(projection);
                sb.AppendLine(String.Format(SuccessfulImportProjection, movieTitle.Title, projection.DateTime.ToString("MM/dd/yyyy")));
            }

            context.Projections.AddRange(projections);
            context.SaveChanges();

            return sb.ToString();
        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            var root = "Customers";
            var data = XmlConverter.Deserializer<CustomerDTO>(xmlString, root);

            StringBuilder sb = new StringBuilder();
            List<Customer> customers = new List<Customer>();

            foreach (var item in data)
            {
                if (IsValid(item))
                {
                    var customer = new Customer
                    {
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        Age = item.Age,
                        Balance = item.Balance
                    };

                    foreach (var tickerDTO in item.Tickets)
                    {
                        if (IsValid(tickerDTO))
                        {
                            var ticket = new Ticket
                            {
                                CustomerId = customer.Id,
                                Price = tickerDTO.Price
                            };

                            customer.Tickets.Add(ticket);
                        }
                    }
                    customers.Add(customer);
                    sb.AppendLine(String.Format(SuccessfulImportCustomerTicket, customer.FirstName, customer.LastName, customer.Tickets.Count));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();
            return sb.ToString();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System
                .ComponentModel
                .DataAnnotations
                .ValidationContext(obj);

            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResult, true);
        }
    }
}