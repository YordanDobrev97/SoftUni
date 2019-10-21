using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>();

            foreach (var author in authors)
            {
                this.Authors.Add(author);
            }
        }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public List<string> Authors { get; private set; }

        public int CompareTo(Book other)
        {
            var resultFirstComparing = this.Year.CompareTo(other.Year);

            if (resultFirstComparing == 0)
            {
                return this.Title.CompareTo(other.Title);
            }

            return resultFirstComparing;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
