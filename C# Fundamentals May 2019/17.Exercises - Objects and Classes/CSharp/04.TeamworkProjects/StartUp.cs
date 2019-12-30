using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    class User
    {
        public string Name { get; private set; }
        public User(string name)
        {
            this.Name = name;
        }
    }

    class Team
    {
        public string Name { get; private set; }
        public List<User> Users { get; set; }

        public Team(string name)
        {
            this.Name = name;
            this.Users = new List<User>();
        }
    }

    public static void Main()
    {
        int countTeam = int.Parse(Console.ReadLine());

        List<Team> teams = new List<Team>();

        for (int i = 0; i < countTeam; i++)
        {
            string[] arguments = Console.ReadLine()
                .Split("-");

            string userName = arguments[0];
            string teamName = arguments[1];

            Team newTeam = new Team(teamName);
            User newUser = new User(userName);

            if (!teams.Contains(newTeam))
            {
                newTeam.Users.Add(newUser);
                teams.Add(newTeam);
            }
            else
            {
                Console.WriteLine($"Team {newTeam} was already created!");
            }
        }

        foreach (var team in teams)
        {
            Console.WriteLine($"Team name: ");
            Console.WriteLine($"{team.Name}");

            foreach (var user in team.Users)
            {
                Console.WriteLine($"User: {user.Name}");
            }
        }
    }
}

