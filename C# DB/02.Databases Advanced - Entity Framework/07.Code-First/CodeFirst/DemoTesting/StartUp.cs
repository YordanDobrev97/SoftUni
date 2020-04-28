using DemoTesting.Data;
using DemoTesting.Models;

namespace DemoTesting
{
    public class StartUp
    {
        public static void Main()
        {
            using var db = new SystemDbContext();

            db.Topics.Add(new Topic()
            {
                Description = "good topic - 2"
            });

            db.SaveChanges();
        }
    }
}
