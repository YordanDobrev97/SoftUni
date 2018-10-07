using System;

namespace Structures
{
    class Program
    {
        static void Main()
        {
            Book[] books = new Book[10];

            Book csharp = new Book();
            csharp.Author = "Svetlin Nakov";
            csharp.Title = "Programming Basics";
            csharp.BookId++;

            Console.WriteLine("Book characteristics:");
            Console.WriteLine("Authour: {0}", csharp.Author);
            Console.WriteLine("Title: {0}", csharp.Title);
            Console.WriteLine("Book Id: {0}", csharp.BookId);
        }
    }
}
