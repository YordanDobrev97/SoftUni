namespace Cinema.DataProcessor
{
    using System;
    using System.Linq;
    using Data;

    public class Serializer
    {
        public static string ExportTopMovies(CinemaContext context, int rating)
        {
            context.Movies
                .Where(m => m.Projections.Any(p => p.Tickets.Any()))
                .Select(m => new
                {
                    MovieName = m.Title,
                    Rating = m.Rating.ToString(),
                    TotalIncomes = m.Projections.Select(p => new
                    {
                        TotalPrice = p.Tickets.Sum(t => t.Price)
                    })
                });

            throw new NotImplementedException();
        }

        public static string ExportTopCustomers(CinemaContext context, int age)
        {
            throw new NotImplementedException();
        }
    }
}