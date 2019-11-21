using System;
using System.Reflection;

public class Tracker
{
   public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(
            BindingFlags.Instance | 
            BindingFlags.Public | 
            BindingFlags.Static);

        foreach (var item in methods)
        {
            var attribute = item.GetCustomAttribute<AuthorAttribute>();

            if (attribute != null)
            {
                Console.WriteLine($"{item.Name} is writter by {attribute.Name}");
            }
        }
    }
}

