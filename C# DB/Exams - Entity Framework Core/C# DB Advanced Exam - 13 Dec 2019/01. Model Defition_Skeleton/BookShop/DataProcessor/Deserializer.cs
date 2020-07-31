namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using XmlFacade;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            var root = "Books";
            var data = XmlConverter.Deserializer<ImportBookDTO>(xmlString, root);

            List<Book> books = new List<Book>();
            StringBuilder sb = new StringBuilder();

            foreach (var item in data)
            {
                if (IsValid(item))
                {
                    Enum.TryParse(item.Genre.ToString(), true, out Genre genre);
                    var book = new Book
                    {
                        Name = item.Name,
                        Genre = genre,
                        Price = item.Price,
                        Pages = item.Pages,
                        PublishedOn = DateTime.ParseExact(item.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture)
                    };

                    books.Add(book);
                    sb.AppendLine(string.Format(SuccessfullyImportedBook, book.Name, book.Price));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Books.AddRange(books);
            context.SaveChanges();

            return sb.ToString();
        }
        
        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            var data = JsonConvert.DeserializeObject<ImportAuthorsDTO[]>(jsonString);

            List<Author> authors = new List<Author>();
            StringBuilder sb = new StringBuilder();

            foreach (var item in data)
            {
                if (IsValid(item))
                {
                    if (authors.Any(a => a.Email == item.Email))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var author = new Author
                    {
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        Email = item.Email,
                        Phone = item.Phone
                    };

                    if (item.Books == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    int countBooks = 0;
                    foreach (var currentBook in item.Books)
                    {
                        Book book = null;

                        if (currentBook.Id.HasValue)
                        {
                            book = context.Books.FirstOrDefault(b => b.Id == currentBook.Id);
                        }

                        if (book == null)
                        {
                            continue;
                        }

                        var authorBook = new AuthorBook
                        {
                            AuthorId = author.Id,
                            BookId = book.Id
                        };

                        author.AuthorsBooks.Add(authorBook);
                        countBooks++;
                    }

                    var fullName = author.FirstName + " " + author.LastName;

                    if (countBooks == 0)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    authors.Add(author);
                    sb.AppendLine(string.Format(SuccessfullyImportedAuthor, fullName, countBooks));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Authors.AddRange(authors);
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