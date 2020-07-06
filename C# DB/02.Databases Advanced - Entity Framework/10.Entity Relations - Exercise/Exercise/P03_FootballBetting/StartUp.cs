using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data;
using P03_FootballBetting.Data.Models;
using System;

namespace P03_FootballBetting
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new FootballBettingContext();
            db.Database.Migrate();

            db.Users.Add(new User()
            {
                Username = "Pesho",
                Password = "123",
                Email = "peshoto@abv.bg",
                Balance = 3000
            });

            db.SaveChanges();
        }
    }
}
