using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            string output = $"{this.Title} -{this.Content}:{this.Author}";
            return output.Trim();
        }
    }

    public class StartUp
    {
        public static void SimplyArticle()
        {
            string[] articlesInput = Console.ReadLine()
                .Split(",");

            Article articles = new Article(articlesInput[0], articlesInput[1],
                articlesInput[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInput = Console.ReadLine()
                    .Split(new[] { ':' },
                    StringSplitOptions.RemoveEmptyEntries);

                string command = commandInput[0];

                switch (command)
                {
                    case "Edit":
                        articles.Edit(commandInput[1]);
                        break;
                    case "ChangeAuthor":
                        articles.ChangeAuthor(commandInput[1]);
                        break;
                    case "Rename":
                        articles.Rename(commandInput[1]);
                        break;
                }
            }

            Console.WriteLine($"{articles.ToString()}");
        }

        public static void Main()
        {
            SimplyArticle();
            /*
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articlesParams = Console.ReadLine()
                    .Split(", ");
                string title = articlesParams[0];
                string content = articlesParams[1];
                string author = articlesParams[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string criteriaPerSort = Console.ReadLine();

            if (criteriaPerSort == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if(criteriaPerSort == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
            */
        }
    }
}