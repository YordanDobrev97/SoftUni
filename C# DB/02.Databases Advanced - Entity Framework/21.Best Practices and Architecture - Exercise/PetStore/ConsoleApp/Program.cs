using Microsoft.EntityFrameworkCore;
using PetStore.Data;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new PetStoreDbContext();
            db.Database.Migrate();
        }
    }
}
