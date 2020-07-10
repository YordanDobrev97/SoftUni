namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();

            //var input = Console.ReadLine();

            var result = GetMostRecentBooks(db);
            Console.WriteLine(result);
        }

        //01.Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, ignoreCase: true);

            var books = context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return String.Join(Environment.NewLine, books);
        }

        //02.Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            //solution 1
            var goldenBooks = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .Select(b => new
                {
                    Id = b.BookId,
                    b.Title
                })
                .OrderBy(b => b.Id)
                .ToList();

            //solution 2
            //var goldenBooks =
            //    context.Books
            //            .Select(b => new
            //            {
            //                BookTitle = b.Title,
            //                EditionType = b.EditionType,
            //                Copies = b.Copies
            //            })
            //            .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
            //            .ToList();

            return String.Join(Environment.NewLine, goldenBooks.Select(b => b.Title));
        }

        //03.Books by Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context
                            .Books
                            .Where(b => b.Price > 40)
                            .Select(b => new
                            {
                                Title = b.Title,
                                Price = b.Price
                            })
                            .OrderByDescending(b => b.Price)
                            .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        //04.Not Released In
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context
                              .Books
                              .Where(b => b.ReleaseDate.Value.Year != year)
                              .Select(b => b.Title)
                              .ToList();

            return String.Join(Environment.NewLine, books);
        }

        //05.Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(c => c.ToLower())
                                   .ToList();

            var titleBooks = new List<string>();

            foreach (var category in categories)
            {
                var booksFromCategory = context.
                                BooksCategories
                                        .Where(bc => 
                                            bc.Category.Name.ToLower() == category)
                                        .Select(b => b.Book.Title)
                                        .ToList();

                titleBooks.AddRange(booksFromCategory);
            }

            titleBooks = titleBooks.OrderBy(b => b).ToList();
            return String.Join(Environment.NewLine, titleBooks);
        }

        //06.Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var parseDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                        .Where(b => b.ReleaseDate.Value.Date < parseDate)
                        .OrderByDescending(b => b.ReleaseDate)
                        .Select(b => new
                        {
                            Title = b.Title,
                            EditionType = b.EditionType,
                            Price = b.Price
                        })
                        .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        //07.Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName
                })
                .OrderBy(a => a.FullName)
                .ToList();

            return String.Join(Environment.NewLine, authors.Select(a => a.FullName));
        }

        //08.Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var titles = context.Books
                                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                                .Select(b => b.Title)
                                .OrderBy(b => b)
                                .ToList();

            return String.Join(Environment.NewLine, titles);
        }

        //09.Book Search by Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksByAuthor = context.Books
                                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                                .Select(b => new
                                {
                                    b.Title,
                                    AuthorName = b.Author.FirstName + " " + b.Author.LastName
                                })
                                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var book in booksByAuthor)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorName})");
            }

            return sb.ToString();
        }

        //10.Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var countBooks = context.Books
                                    .Count(b => b.Title.Length > lengthCheck);

            return countBooks;
        }

        //11.Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var copiesCountAuthor = context.Authors
                                    .Select(a => new
                                    {
                                        Name = a.FirstName + " " + a.LastName,
                                        Copies = a.Books.Sum(b => b.Copies)
                                    })
                                    .OrderByDescending(b => b.Copies)
                                    .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in copiesCountAuthor)
            {
                sb.AppendLine($"{item.Name} - {item.Copies}");
            }

            return sb.ToString();
        }

        //12.Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                                .Select(c => new
                                {
                                    Category = c.Name,
                                    Profit = c.CategoryBooks.Select(b => b.Book.Copies * b.Book.Price)
                                                            .Sum()
                                })
                                .OrderByDescending(b => b.Profit)
                                .ThenBy(b => b.Category)
                                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var category in categories)
            {
                sb.AppendLine($"{category.Category} ${category.Profit:f2}");
            }

            return sb.ToString();
        }

        //13.Most Recent Books
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var mostRecentBooks = context
                                .Categories
                                .Select(c => new
                                {
                                    CategoryName = c.Name,
                                    Books = c.CategoryBooks
                                                .OrderByDescending(cb => cb.Book.ReleaseDate)
                                                .Take(3)
                                                .Select(cb => new
                                                {
                                                    cb.Book.Title,
                                                    cb.Book.ReleaseDate.Value.Year
                                                })
                                })
                                .OrderBy(c => c.CategoryName)
                                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var category in mostRecentBooks)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.Year})");
                }

            }
            return sb.ToString();
        }

        //14.Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books.Where(c => c.ReleaseDate.Value.Year < 2010);

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        //15.Remove Books
        public static int RemoveBooks(BookShopContext context)
        {
            var removedBooks = context.Books
                                    .Where(b => b.Copies < 4200)
                                    .ToList();

            foreach (var book in removedBooks)
            {
                context.Books.Remove(book);
            }

            context.SaveChanges();
            return removedBooks.Count();
        }
    }
}