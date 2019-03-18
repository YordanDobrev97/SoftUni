using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    class Phrase
    {
        public string Content { get; set; }

        public Phrase(string content)
        {
            this.Content = content;
        }
    }

    class Event
    {
        public string ContentEvent { get; set; }

        public Event(string contentEvent)
        {
            this.ContentEvent = contentEvent;
        }
    }

    class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            this.Name = name;
        }
    }

    class City
    {
        public string Name { get; set; }

        public City(string name)
        {
            this.Name = name;
        }
    }

    public class StartUp
    {
        public static void Main()
        {
            int numberOfMessage = int.Parse(Console.ReadLine());

            List<Phrase> phrases = new List<Phrase>()
            {
                new Phrase("Excellent product."),
                new Phrase("Such a great product."),
                new Phrase("I always use that product."),
                new Phrase("Best product of its category."),
                new Phrase("Exceptional product."),
                new Phrase("I can’t live without this product.")
            };
            List<Event> events = new List<Event>()
            {
                new Event("Now I feel good."),
                new Event("I have succeeded with this product."),
                new Event("Makes miracles."),
                new Event("I am happy of the results!"),
                new Event("I cannot believe but now I feel awesome."),
                new Event("Try it yourself"),
                new Event("I am very satisfied."),
                new Event("I feel great!")
            };
            List<Author> authors = new List<Author>()
            {
                new Author("Diana"),
                new Author("Petya"),
                new Author("Stella"),
                new Author("Elena"),
                new Author("Katya"),
                new Author("Iva"),
                new Author("Annie"),
                new Author("Eva")
            };
            List<City> cities = new List<City>()
            {
                new City("Burgas"),
                new City("Sofia"),
                new City("Plovdiv"),
                new City("Varna"),
                new City("Ruse")
            };

            Random random = new Random();
            string randomPhrase = phrases[random.Next(0, phrases.Count)].Content;
            string randomEvent = events[random.Next(0, events.Count)].ContentEvent;
            string randomAuthor = authors[random.Next(0, authors.Count)].Name;
            string randomCity = cities[random.Next(0, cities.Count)].Name;

            Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}");
        }
    }
}
